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
    public class ExchangeController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public ExchangeController(csiGenizPOSContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Vexchange> Get()
        {
            return _context.Vexchanges.FromSqlRaw("SELECT * FROM [dbo].[Vexchange]");

        }

        [HttpGet("{i}/{excid}")]
        public IEnumerable<Vexchange> GetACode(String excid)
        {
            return _context.Vexchanges.FromSqlRaw("SELECT * FROM [dbo].[Vexchange] ( '" + excid + "' )");
        

        }

    }
}
