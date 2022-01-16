using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using csiWSGeniuzPOS.Model;
using csiWSGeniuzPOS.Data;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using Exception = System.Exception;

namespace csiWSGeniuzPOS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PmUnitPriceController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;
        public PmUnitPriceController(csiGenizPOSContext context)
        {
            _context = context;
        }




        [HttpGet("{plu}")]
        public IEnumerable<PmUnitPrice> GetACode(String plu)
        {
            return _context.PmUnitPrices.FromSqlRaw("SELECT * FROM [dbo].[getUnitPrice] ( '','','" + plu + "' )");

        }

        [HttpGet("{i}/{posid}/{mbid}/{plu}")]
        public IEnumerable<PmUnitPrice> GetPmUnitPriceByPlu(String posid, String mbid, String plu)
        {
           
            try
            {
                if (mbid == null || mbid == " ")
                {
                    mbid = "";
                }
                return _context.PmUnitPrices.FromSqlRaw("SELECT * FROM [dbo].[getUnitPrice] ( '" + posid + "','" + mbid + "','" + plu + "' )");
            }
            catch (InvalidCastException e)
           
          
            {
                String error = e.Message.ToString();
                return (IEnumerable<PmUnitPrice>)Enumerable.Empty<object[]>();
            }


            

        }
    }
}

