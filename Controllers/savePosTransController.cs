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
    public class savePosTransController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public savePosTransController(csiGenizPOSContext context)
        {
            _context = context;
        }


        //--Specification :
        //--allocateBillDiscProcess()
        //--CalculateMemberPoint() --not implement now!
        //--CalculateBillVat(...)... Calvat()
        //--InsertPosTrans() [Total ->HD]sum() [Item -DT] ->DereiveComponentFromLineItem(...sales,discount, charge..)
        //--UpdateSalesToPosShiftControl()
        //--If PosProcessMode='I' ;
        //----if SalesMode = 1 (sales bill) =>PostSalesTransToStock()--not implement now
        //----els (return bill) => PostSalesRetnTranToStock() --not implement now
        //--if EjournalFg = 1 => SaveEjournal() --not implement now

        //--Design for Specification to web services
        //---PORTS: for saveData() from UI to MSSQL

        //--Receive Trans Data -> (Salesitems(+ Discount, Charge) , BillItems, ReceiptItems)
        ////--Start receive date...till end of data
        ////----Receive Start Bill Save Status...
        ////-------Temp Bill Recording...
        ////----------Temp sales item (+discount, charge)
        ////------------start/end ... pass sales summary Data
        ////--------------port: start :end  with new docno ...loop records

        ////----------Temp bill disc/charge items
        ////------------start/end ... pass bill disc/charge summary Data
        ////--------------port: start :end  with new docno ...loop records

        ////----------Temp receipt items
        ////------------start/end ... pass receipts summary Data
        ////--------------port: start :end  with new docno ...loop records
        ///
        ////----------Temp Header bill
        ////------------start/end ... pass summary Data
        ////--------------port: start :end  with new docno ...single record
        ////----Receive End Bill Save Status...

        //--when receipt finished will end of that bill then
        //--AllocateBillDiscProcess()
        //----action on UI process--must same as on slip printing out!
        //--Save to POS TRANSACTIONS (psPosTranHd,psPosTranDt,psPosTranDisc,psPosTranRecv)
        //--Update that PosShiftCtrl records with Total/Summary

        //--Write Ejournal (not implement now) 

        [HttpPut("{posid}/{docno}/{status}/{linemode}/{data}")]
        public async Task<IActionResult> saveAposTrans(string posid, string docno, String status, string linemode, string data)
        {
            //--DATA PORT for SavePosTransactions (SalesItem, Bill DIscount/charge items, Receipt items)
            //--docno/status = 'XXXXXXXXX'/'S', 'XXXXXXXXX'/'E'
            //--data ???  sales item (+discount, charge) -- has already calculated!
            ////--------------port: start :end  with new docno ...loop records
            ///----linemode : 1-salesitem, 2-billDiscCharge, 3-billReceipts
           
            try
            {
                if (status == "S")
                {
                    //--Start getting info to save doc. maybe future add verify data here.
                    //--By update POS CONTROL
                    using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                    {
                        cmd.CommandText = "[dbo].[StartSavePOSTRANS]";
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                        cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                  

                        cmd.ExecuteNonQuery();
                    }



                }
                else if (status == "E")
                {
                    //--End  getting info to save doc. maybe future add verify data here.
                    //--this will calculate psPostranHd data form server lines item data and update poscontrol. 
                    //--by open PORT to MSSQL.procedure to execute those processes.
                    String vattype, tverify,  cashier, refdoc, mbid, slmnid, cashIn, cashOut,shiftId;


                    vattype = checkNull(data, 0);
                    tverify = checkNull(data, 1);
                    cashier = checkNull(data, 2);
                    refdoc = checkNull(data, 3);
                    mbid = checkNull(data, 4);
                    slmnid = checkNull(data, 5);
                    cashIn = checkNull(data, 6);
                    cashOut = checkNull(data, 7);
                    shiftId = checkNull(data, 8);
                    String sparams = "'" + docno +  "','" + vattype + "'," + tverify + ",'" + posid + "','" + 
                        cashier + "','" + refdoc + "','" + mbid + "','" + slmnid + "'";
                    try
                    {

                        using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                        {
                            cmd.CommandText = "[dbo].[addPosTranHd]";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                            cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                            cmd.Parameters.Add(new SqlParameter("SaleVateType", SqlDbType.VarChar) { Value = vattype });
                            cmd.Parameters.Add(new SqlParameter("TotalVerify", SqlDbType.Decimal) { Value = decimal.Parse(tverify) });
                            cmd.Parameters.Add(new SqlParameter("PosId", SqlDbType.VarChar) { Value = posid });
                            cmd.Parameters.Add(new SqlParameter("Cashier", SqlDbType.VarChar) { Value = cashier });
                            cmd.Parameters.Add(new SqlParameter("RefDocNo", SqlDbType.VarChar) { Value = refdoc });
                            cmd.Parameters.Add(new SqlParameter("MbId", SqlDbType.VarChar) { Value = mbid });
                            cmd.Parameters.Add(new SqlParameter("SalesmanId", SqlDbType.VarChar) { Value = slmnid });
                            //---ShiftControl Variables --- for updating data ---
                            cmd.Parameters.Add(new SqlParameter("CashIn", SqlDbType.Decimal) { Value = decimal.Parse(cashIn) });
                            cmd.Parameters.Add(new SqlParameter("CashOut", SqlDbType.Decimal) { Value = decimal.Parse(cashOut) });
                            cmd.Parameters.Add(new SqlParameter("ShiftId", SqlDbType.Int) { Value = int.Parse(shiftId) });

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return NotFound();
                    }
                   
                }
                else if (status == "R")
                {
                    //--End  getting info to save doc. maybe future add verify data here.
                    //--this will calculate psPostranHd data form server lines item data and update poscontrol. 
                    //--by open PORT to MSSQL.procedure to execute those processes.
                    String vattype, tverify, cashier, refdoc, mbid, slmnid, cashIn, cashOut, shiftId;


                    vattype = checkNull(data, 0);
                    tverify = checkNull(data, 1);
                    cashier = checkNull(data, 2);
                    refdoc = checkNull(data, 3);
                    mbid = checkNull(data, 4);
                    slmnid = checkNull(data, 5);
                    cashIn = checkNull(data, 6);
                    cashOut = checkNull(data, 7);
                    shiftId = checkNull(data, 8);
                    String sparams = "'" + docno + "','" + vattype + "'," + tverify + ",'" + posid + "','" +
                        cashier + "','" + refdoc + "','" + mbid + "','" + slmnid + "'";
                    try
                    {

                        using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                        {
                            cmd.CommandText = "[dbo].[addRefundHd]";
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;
                            if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                            cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                            cmd.Parameters.Add(new SqlParameter("SaleVateType", SqlDbType.VarChar) { Value = vattype });
                            cmd.Parameters.Add(new SqlParameter("TotalVerify", SqlDbType.Decimal) { Value = decimal.Parse(tverify) });
                            cmd.Parameters.Add(new SqlParameter("PosId", SqlDbType.VarChar) { Value = posid });
                            cmd.Parameters.Add(new SqlParameter("Cashier", SqlDbType.VarChar) { Value = cashier });
                            cmd.Parameters.Add(new SqlParameter("RefDocNo", SqlDbType.VarChar) { Value = refdoc });
                            cmd.Parameters.Add(new SqlParameter("MbId", SqlDbType.VarChar) { Value = mbid });
                            cmd.Parameters.Add(new SqlParameter("SalesmanId", SqlDbType.VarChar) { Value = slmnid });
                            //---ShiftControl Variables --- for updating data ---
                            cmd.Parameters.Add(new SqlParameter("CashIn", SqlDbType.Decimal) { Value = decimal.Parse(cashIn) });
                            cmd.Parameters.Add(new SqlParameter("CashOut", SqlDbType.Decimal) { Value = decimal.Parse(cashOut) });
                            cmd.Parameters.Add(new SqlParameter("ShiftId", SqlDbType.Int) { Value = int.Parse(shiftId) });

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return NotFound();
                    }

                }
                else {
                   

                    if (linemode == "1")
                    {
                        //---translate(extract) data to sales item
                        //@PosId+ ] + @Cashier+ ] + @saleItems+ ] +@plu +] +@qty
                        //+]+ @price +]+ @discode +] +@amount +]+ @vatcode +]+ @unit
                        String[] d = data.Split(']');
                        String sposid, sdocno,lineno, cashier, salesitem, plu, sqty, sprice, discode, samt, vatcode, unit, discamt;

                        sposid = posid;
                        sdocno = docno;
                        lineno = d[0];
                        cashier = d[1];
                        salesitem = d[2];
                        plu = d[3];
                        sqty = d[4];
                        sprice = d[5];
                        discode = d[6];
                        samt = d[7];
                        vatcode = d[8];
                        unit = d[9];
                        discamt = d[10];
                        //--linemode : 1: salesitem (sales [itemtype='10'],discount [itemtype='2X'], charge  [itemtype='3X'])
                        try
                        {
                           
                         

                            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                            {
                                cmd.CommandText = "[dbo].[addPosTranDt]";
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                                cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = sdocno });
                                cmd.Parameters.Add(new SqlParameter("PosId", SqlDbType.VarChar) { Value = sposid });
                                cmd.Parameters.Add(new SqlParameter("LineNo", SqlDbType.VarChar) { Value = Int16.Parse(lineno) });
                                cmd.Parameters.Add(new SqlParameter("Cashier", SqlDbType.VarChar) { Value = cashier });
                                cmd.Parameters.Add(new SqlParameter("saleItems", SqlDbType.VarChar) { Value = salesitem });
                                cmd.Parameters.Add(new SqlParameter("plu", SqlDbType.VarChar) { Value = plu });
                                cmd.Parameters.Add(new SqlParameter("qty", SqlDbType.Decimal) { Value = decimal.Parse(sqty) });
                                cmd.Parameters.Add(new SqlParameter("price", SqlDbType.Decimal) { Value = decimal.Parse(sprice) });
                                cmd.Parameters.Add(new SqlParameter("discode", SqlDbType.VarChar) { Value = discode });
                                cmd.Parameters.Add(new SqlParameter("amount", SqlDbType.Decimal) { Value = decimal.Parse(samt) });
                                cmd.Parameters.Add(new SqlParameter("vatcode", SqlDbType.VarChar) { Value = vatcode });
                                cmd.Parameters.Add(new SqlParameter("unit", SqlDbType.VarChar) { Value = unit });
                                cmd.Parameters.Add(new SqlParameter("discamt", SqlDbType.VarChar) { Value = decimal.Parse(discamt) });

                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return NotFound();
                        }

                    }
                    else if (linemode.Substring(0, 1) == "2") {
                        //--linemode : 2: salesitem (sales discount [itemtype='2X'])
                        //---translate(extract) data to sales item by type and keep data only the side due with
                     
                        String[] d = data.Split(']');
                        String itemtype,  reflineno, discpc, discamt, coupontype, couponno, promoid, chargepc, chargeamt, itemdesc;

                       
                        itemtype = d[0];
                        reflineno = d[1];
                        coupontype = d[2];
                        couponno = d[3];
                        promoid = d[4];
                        discpc = d[5];
                        discamt = d[6];
                        chargepc = d[7];
                        chargeamt = d[8];
                        itemdesc = d[9];
                     
                        try
                        {
                          

                            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                            {
                                cmd.CommandText = "[dbo].[addPosTranDtDisc]";
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                                cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                                cmd.Parameters.Add(new SqlParameter("itemtype", SqlDbType.VarChar) { Value = itemtype });
                                cmd.Parameters.Add(new SqlParameter("reflineno", SqlDbType.SmallInt) { Value = Int16.Parse(reflineno.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("coupontype", SqlDbType.VarChar) { Value = coupontype });
                                cmd.Parameters.Add(new SqlParameter("couponno", SqlDbType.VarChar) { Value = couponno });
                                cmd.Parameters.Add(new SqlParameter("promoid", SqlDbType.VarChar) { Value = promoid });
                                cmd.Parameters.Add(new SqlParameter("discpc", SqlDbType.Decimal) { Value = decimal.Parse(discpc.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("discamt", SqlDbType.Decimal) { Value = decimal.Parse(discamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("chargepc", SqlDbType.Decimal) { Value = decimal.Parse(chargepc.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("chargeamt", SqlDbType.Decimal) { Value = decimal.Parse(chargeamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("itemdesc", SqlDbType.VarChar) { Value = itemdesc });
                              
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return NotFound();
                        }
                    }
                    else if (linemode.Substring(0,1) == "3")
                    {
                        //--linemode : 3: salesitem (charge  [itemtype='3X'])
                        //---translate(extract) data to sales item by type and keep data only the side due with

                        String[] d = data.Split(']');
                        String itemtype, reflineno, discpc, discamt, coupontype, couponno, promoid, chargepc, chargeamt, itemdesc;


                        itemtype = d[0];
                        reflineno = d[1];
                        coupontype = d[2];
                        couponno = d[3];
                        promoid = d[4];
                        discpc = d[5];
                        discamt = d[6];
                        chargepc = d[7];
                        chargeamt = d[8];
                        itemdesc = d[9];

                        try
                        {
                        
                            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                            {
                                cmd.CommandText = "[dbo].[addPosTranDtDisc]";
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                                cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                                cmd.Parameters.Add(new SqlParameter("itemtype", SqlDbType.VarChar) { Value = itemtype });
                                cmd.Parameters.Add(new SqlParameter("reflineno", SqlDbType.SmallInt) { Value = Int16.Parse(reflineno.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("coupontype", SqlDbType.VarChar) { Value = coupontype });
                                cmd.Parameters.Add(new SqlParameter("couponno", SqlDbType.VarChar) { Value = couponno });
                                cmd.Parameters.Add(new SqlParameter("promoid", SqlDbType.VarChar) { Value = promoid });
                                cmd.Parameters.Add(new SqlParameter("discpc", SqlDbType.Decimal) { Value = decimal.Parse(discpc.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("discamt", SqlDbType.Decimal) { Value = decimal.Parse(discamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("chargepc", SqlDbType.Decimal) { Value = decimal.Parse(chargepc.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("chargeamt", SqlDbType.Decimal) { Value = decimal.Parse(chargeamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("itemdesc", SqlDbType.VarChar) { Value = itemdesc });

                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return NotFound();
                        }
                    }
                    else if (linemode == "B")
                    {
                        //----linemode :  B - billDiscCharge Items
                        String[] d = data.Split(']');
                        String itemtype, lineno, discpc, discamt, coupontype, couponno, promoid, chargepc, chargeamt;


                        itemtype = d[0]; 
                        lineno = d[1];
                        coupontype = d[2];
                        couponno = d[3];
                        promoid = d[4];
                        discpc = d[5];
                        discamt = d[6];
                        chargepc = d[7];
                        chargeamt = d[8];
                        //itemdesc = d[9];

                        try
                        {

                            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                            {
                                cmd.CommandText = "[dbo].[addPosTranDisc]";
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                                cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                                cmd.Parameters.Add(new SqlParameter("itemtype", SqlDbType.VarChar) { Value = itemtype });
                                cmd.Parameters.Add(new SqlParameter("lineno", SqlDbType.SmallInt) { Value = Int16.Parse(lineno.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("coupontype", SqlDbType.VarChar) { Value = coupontype });
                                cmd.Parameters.Add(new SqlParameter("couponno", SqlDbType.VarChar) { Value = couponno });
                                cmd.Parameters.Add(new SqlParameter("promoid", SqlDbType.VarChar) { Value = promoid });
                                cmd.Parameters.Add(new SqlParameter("discpc", SqlDbType.Decimal) { Value = decimal.Parse(discpc.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("discamt", SqlDbType.Decimal) { Value = decimal.Parse(discamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("chargepc", SqlDbType.Decimal) { Value = decimal.Parse(chargepc.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("chargeamt", SqlDbType.Decimal) { Value = decimal.Parse(chargeamt.Trim()) });
                              //  cmd.Parameters.Add(new SqlParameter("itemdesc", SqlDbType.VarChar) { Value = itemdesc });

                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return NotFound();
                        }

                    }
                    else if (linemode == "R")
                    {
                        //---translate(extract) data to sales item by type and keep data only the side due with

                       // String[] d = data.Split(']');
                        String lineno, paytype, receiptamt, reftype, refno, pointburn, curcycode, curcyamt, excrate;


                        paytype = checkNull(data,0);
                        lineno = checkNull(data,1);
                        receiptamt = checkNull(data,2);
                        reftype = checkNull(data,3);
                        refno = checkNull(data,4);
                        pointburn = checkNull(data,5);
                        curcycode = checkNull(data,6);
                        curcyamt = checkNull(data,7);
                        excrate = checkNull(data,8);

                        try
                        {

                            using (var cmd = _context.Database.GetDbConnection().CreateCommand())
                            {
                                cmd.CommandText = "[dbo].[addPosTranRecv]";
                                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                                if (cmd.Connection.State != System.Data.ConnectionState.Open) cmd.Connection.Open();
                                cmd.Parameters.Add(new SqlParameter("docno", SqlDbType.VarChar) { Value = docno });
                                cmd.Parameters.Add(new SqlParameter("lineno", SqlDbType.SmallInt) { Value = Int16.Parse(lineno.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("paytype", SqlDbType.VarChar) { Value = paytype });
                                cmd.Parameters.Add(new SqlParameter("receiptamt", SqlDbType.Decimal) { Value = decimal.Parse(receiptamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("reftype", SqlDbType.VarChar) { Value = reftype });
                                cmd.Parameters.Add(new SqlParameter("refno", SqlDbType.VarChar) { Value = refno });
                                cmd.Parameters.Add(new SqlParameter("pointburn", SqlDbType.Decimal) { Value = decimal.Parse(pointburn.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("curcycode", SqlDbType.VarChar) { Value = curcycode });
                                cmd.Parameters.Add(new SqlParameter("curcyamt", SqlDbType.Decimal) { Value = decimal.Parse(curcyamt.Trim()) });
                                cmd.Parameters.Add(new SqlParameter("exchangerate", SqlDbType.Decimal) { Value = decimal.Parse(excrate.Trim()) });
                              
                                cmd.ExecuteNonQuery();
                            }
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return NotFound();
                        }
                    }
                    
                   
                }
             
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }
        String checkNull(String data, int i) {
            String[] d = data.Split(']');
            if (i > d.Length-1)
            {
                return "";
            }
            else {
                if (d[i] == null)
                {
                    return "";
                }
                else
                {
                    return d[i];
                }
            }
            
        }


        [HttpGet("{ve}/{docno}")]
        public IEnumerable<vatSalesItem> GetACode(String docno)
        {
            return _context.vatSalesItems.FromSqlRaw("SELECT * FROM [dbo].[getSalesItemVatExclusive] ( '" + docno + "' )");

        }

        [HttpGet("{docno}")]
        public IEnumerable<getPosTranHd> getpostranshd(String docno)
        {
            return _context.getPosTranHds.FromSqlRaw("SELECT * FROM [dbo].[getPosTranHd] ( '" + docno + "' )");
           
        }

        [HttpGet("{docno}/{2}/{3}")]
        public IEnumerable<getPosTranDt> gettrantdt(String docno)
        {
           
                return _context.getPosTranDts.FromSqlRaw("SELECT * FROM [dbo].[getPosTranDt] ( '" + docno + "' )")
                .OrderBy(e => e.LineItemNo).ThenBy(f => f.LineItemType).ThenBy(g => g.Id);


        }
        [HttpGet("{shopid}/{posId}/{3}/{4}/{5}/{6}/{7}")]
        public IEnumerable<getPosTranDt> gettrantdtOnSales(String shopid, String posId)
        {

            return _context.getPosTranDts.FromSqlRaw("SELECT * FROM [dbo].[getPosTranDtOnSales] ( '" + shopid + "','" + posId + "' )")
                .OrderBy(e => e.LineItemNo).ThenBy(f => f.LineItemType).ThenBy(g => g.Id);

        }
        [HttpGet("{docno}/{2}/{3}/{4}")]
        public IEnumerable<getPosTranDisc> gettrantdisc(String docno)
        {

            return _context.getPosTranDiscs.FromSqlRaw("SELECT * FROM [dbo].[getPosTranDisc] ( '" + docno + "' )");

        }
        [HttpGet("{docno}/{2}/{3}/{4}/{5}/{6}")]
        public IEnumerable<getPosTranReceipt> gettrantrecv(String docno)
        {

            return _context.getPosTranReceipts.FromSqlRaw("SELECT * FROM [dbo].[getPosTranReceipt] ( '" + docno + "' )");

        }
    }
}
