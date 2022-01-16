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
//using Dapper;
using System.Data;

namespace csiWSGeniuzPOS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GetActivePosStationController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public GetActivePosStationController(csiGenizPOSContext context)
        {
            _context = context;
        }
     

        [HttpPut("{posid}/{cashier}/{serviceip}")]
        public async Task<IActionResult> SetIpActivePos(String posid, String cashier, String serviceip)
        {
            try
            {
                String ip = serviceip.Replace("[", "http://").Replace("[[", "https://");
                
                using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                {
                    cmd.CommandText = "[dbo].[setActivePosIP]";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                    cmd.Parameters.Add(new SqlParameter("posid", SqlDbType.VarChar) { Value = posid });
                    cmd.Parameters.Add(new SqlParameter("ip", SqlDbType.VarChar) { Value = ip });
                    cmd.Parameters.Add(new SqlParameter("cashier", SqlDbType.VarChar) { Value = cashier });


                    cmd.ExecuteNonQuery();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return Ok("good");
        }

        [HttpGet("{posid}")]
        public IEnumerable<getActivePosStation> GetACode(String posid)
        {
            return _context.getActivePosStations.FromSqlRaw("SELECT * FROM [dbo].[getActivePosStation] ( '" + posid + "' )");

        }

    }
}
