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
    public class CsParamController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public CsParamController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Vposparam> Get()
        {
            return _context.Vposparams.AsEnumerable();

        }
        [HttpGet("{posid}")]
        public IEnumerable<Vposparam> GetACode(String posid)
        {
            return _context.Vposparams.Where(a => a.PosId == posid).AsEnumerable();

        }

        [HttpGet("{i}/{posid}")]
        public IEnumerable<Vposparam> GetLikeCode(String posid)
        {
            return _context.Vposparams.Where(a => a.PosId.Contains(posid)).AsEnumerable();

        }

    }
}
