using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csiWSGeniuzPOS.Model;
using csiWSGeniuzPOS.Data;
using Microsoft.Data.SqlClient;

namespace csiWSGeniuzPOS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GetSaleItemController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public GetSaleItemController(csiGenizPOSContext context)
        {
            _context = context;
        }
       
        [HttpGet("{plu}")]
        public IEnumerable<VgetSalesItem> GetACode(String plu)
        {
            return _context.VgetSalesItems.FromSqlRaw("SELECT * FROM [dbo].[getSalesItem] ( '','','" + plu + "' )");

        }

        [HttpGet("{i}/{posid}/{mbid}/{plu}")]
        public IEnumerable<VgetSalesItem>   GetLikeCode(String posid, String mbid, String plu)
        {
            if (mbid == null)
            {
                mbid = "";
            }
            return _context.VgetSalesItems.FromSqlRaw("SELECT * FROM [dbo].[getSalesItem] ( '"+ posid + "','"+mbid+"','"+plu+"' )");
           

        }

      

    }
}
