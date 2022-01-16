using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csiWSGeniuzPOS.Model;
using csiWSGeniuzPOS.Data;

namespace csiWSGeniuzPOS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CsPlusController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public CsPlusController(csiGenizPOSContext context)
        {
            _context = context;
        }
       
        [HttpGet("{plu}")]
        public IEnumerable<VpsPlu> GetACode(String plu)
        {
            return _context.VpsPlus.FromSqlRaw("SELECT * FROM [dbo].[VpsPLU] Where PluCode='" + plu + "'");
           // return _context.VpsPlus.Where(a=>a.PluCode==plu).AsEnumerable();

        }

        [HttpGet("{i}/{plu}")]
        public IEnumerable<VpsPlu> GetLikeCode(String plu)
        {
            return _context.VpsPlus.FromSqlRaw("SELECT * FROM [dbo].[VpsPLU] Where PluCode like'%" + plu + "%'");
            //return _context.VpsPlus.Where(a => a.PluCode.Contains(plu)).AsEnumerable();

        }


        [HttpGet("{s}/{style}/{plu}")]
        public IEnumerable<VpsPlu> GetArticleLikeCode(String style, String plu)
        {
            //--plu not use but must send 999 or some value for get this API structure!
            return _context.VpsPlus.FromSqlRaw("SELECT top 50 *  FROM [dbo].[VpsPLU] where StyleId='" + style + "'");
           // return _context.VpsPlus.Where(a => a.ArticleStyle == style).AsEnumerable();

        }


    }
}


