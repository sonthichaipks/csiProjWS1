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
    public class PluPricesController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public PluPricesController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet("{plu}")]
        public IEnumerable<PluPrice> GetACode(String plu)
        {
            return _context.PluPrices.FromSqlRaw("SELECT * FROM [dbo].[getPrice] ( '','','" + plu + "' )");

        }

        [HttpGet("{i}/{posid}/{mbid}/{plu}")]
        public IEnumerable<PluPrice> GetLikeCode(String posid, String mbid, String plu)
        {
            if (mbid == null)
            {
                mbid = "";
            }
            return _context.PluPrices.FromSqlRaw("SELECT * FROM [dbo].[getPrice] ( '" + posid + "','" + mbid + "','" + plu + "' )");


        }


    }
}
