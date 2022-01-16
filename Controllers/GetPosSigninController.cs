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
    public class GetPosSigninController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public GetPosSigninController(csiGenizPOSContext context)
        {
            _context = context;
        }


        [HttpGet("{i}/{posid}/{cashierid}")]
        public IEnumerable<VgetPosSignin> GetLikeCode(String posid, String cashierid)
        {

            return _context.VgetPosSignins.FromSqlRaw("SELECT * FROM [dbo].[getPosSignin] ( '" + posid + "','" + cashierid  + "' )");


        }
    }
}
