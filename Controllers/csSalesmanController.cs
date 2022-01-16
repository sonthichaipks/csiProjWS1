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
    public class csSalesmanController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public csSalesmanController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<PsSalesman> Get()
        {
            return _context.PsSalesmen.AsEnumerable();

        }
        [HttpGet("{slmid}")]
        public IEnumerable<PsSalesman> GetACode(String slmid)
        {
            return _context.PsSalesmen.Where(a => a.SalesmanId == slmid).AsEnumerable();

        }

        [HttpGet("{i}/{slmid}")]
        public IEnumerable<PsSalesman> GetLikeCode(String slmid)
        {
            return _context.PsSalesmen.Where(a => a.SalesmanId.Contains(slmid)).AsEnumerable();

        }

    }
}
