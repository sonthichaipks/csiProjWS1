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
    public class CsMembersController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public CsMembersController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<VpsMember> Get()
        {
            return _context.VpsMembers.AsEnumerable();

        }
        [HttpGet("{mbid}")]
        public IEnumerable<VpsMember> GetACode(String mbid)
        {
            return _context.VpsMembers.Where(a => a.MbId == mbid).AsEnumerable();

        }

        [HttpGet("{i}/{mbid}")]
        public IEnumerable<VpsMember> GetLikeCode(String mbid)
        {
            return _context.VpsMembers.Where(a => a.MbId.Contains(mbid)).AsEnumerable();

        }

    }
}
