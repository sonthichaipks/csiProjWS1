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
    public class PosshiftController : ControllerBase
    {

        private readonly csiGenizPOSContext _context;

        public PosshiftController(csiGenizPOSContext context)
        {
            _context = context;
        }

       
        [HttpPut("{a}/{posid}/{cashierid}/{begcash}")]
        public async Task<IActionResult> addShift(String posid, String cashierid, decimal begcash)
        {

            try
            {
                PsPosShiftControl addsh = new PsPosShiftControl();
                addsh.PosId = posid;
                addsh.CashierId = cashierid;
                addsh.BegCash = (decimal)begcash;
                addsh.CashIn = 0;
                addsh.CashOut = 0;
                addsh.CashBalance = (decimal)begcash;
                addsh.Charge = 0;
                addsh.CountCancel = 0;
                addsh.CountCashOut = 0;
                addsh.CountOpenDrawer = 0;
                addsh.CountRefund = 0;
                addsh.CountVoid = 0;
                addsh.CreateBy = cashierid;
                addsh.UpdateBy = cashierid;
                addsh.CreateDate = DateTime.Now;
                addsh.LastUpdate = DateTime.Now;
                addsh.GrossAmt = 0;
                addsh.NetSales = 0;
                addsh.RecvByCash = 0;
                addsh.RecvByCashCd = 0;
                addsh.RecvByCoupon = 0;
                addsh.RecvByCreditCd = 0;
                addsh.RecvByDebitCd = 0;
                addsh.RecvByOthers = 0;
                addsh.RecvByPoint = 0;
                addsh.ShiftStatus = "O";
                addsh.SingInDate = DateTime.Now.Date;
                addsh.SingInTime = DateTime.Now;
                addsh.SingOutDate = DateTime.Now.Date;
                addsh.SingOutTime = DateTime.Now;
                addsh.StartReceiptNo = "";
                addsh.EndReceiptNo = "";
                addsh.StartRefundNo = "";
                addsh.EndRefundNo = "";
                


                try
                {
                    _context.PsPosShiftControls.Add(addsh);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) 
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }


        [HttpPut("{id}/{status}")]
        public async Task<IActionResult> statusFlag(int id, String status)
        {

            try
            {
                var _posshift = await _context.PsPosShiftControls.FindAsync(id);
                if (_posshift == null)
                {
                    return NotFound();
                }
                _posshift.ShiftStatus = status;
                //_posshift.IsComplete = todoItemDTO.IsComplete;

                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) when (!CheckExists(id))
                {
                    return NotFound();
                }
            }
            catch (DbUpdateConcurrencyException) 
            {
                return NotFound();
            }


            return NoContent();

        }


        private bool CheckExists(int id) =>
             _context.PsPosShiftControls.Any(e => e.Id == id);

    }
}
