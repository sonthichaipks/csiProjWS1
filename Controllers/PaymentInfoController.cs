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
using System.Data;
namespace csiWSGeniuzPOS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentInfoController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public PaymentInfoController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet("{paytype}")]
        public IEnumerable<PaymentInfo> GetACode(String paytype)
        {
            return _context.PaymentInfos.FromSqlRaw("SELECT * FROM [dbo].[getPaymentInfo] ( '" + paytype + "')");

        }
    }
}
