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

namespace csiWSGeniuzPOS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PnlItemController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public PnlItemController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<PsPanelItemButton> Get()
        {
            return _context.PsPanelItemButtons.AsEnumerable();

        }
        [HttpGet("{touchtype}/{groupId}")]
        public IEnumerable<PsPanelItemButton> GetACode(String touchtype, Int16 groupId)
        {
            return _context.PsPanelItemButtons.Where(a => a.TouchPanelType == touchtype && a.GroupButtonId == groupId).OrderBy(e=>e.ItemButtonId).AsEnumerable();

        }

        [HttpPut("{s}/{touchtype}/{groupId}")]
        public async Task<IActionResult> sortButton(String touchtype, Int16 groupId)
        {
           
            try
            {
                Int16 startId = 0;
                IEnumerable<PsPanelItemButton> list =_context.PsPanelItemButtons.Where(a => a.TouchPanelType == touchtype && a.GroupButtonId == groupId).OrderBy(e => e.ItemButtonLabel).AsEnumerable();
                foreach (var addsh in list)
                {
                    // PsPanelItemButton addsh = new PsPanelItemButton();
                    startId += 1;
                    addsh.ItemButtonId = startId;
                  
                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;
                    _context.PsPanelItemButtons.Update(addsh);
                  

                };
                await _context.SaveChangesAsync();
               
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }

        [HttpPut("{a}/{touchtype}/{groupId}/{pnlid}/{hexCbg}/{hexClebel}/{fntSize}/{linkfg}/{linkcode}/{pnllabel}/{pnlimgurl}")]
        public async Task<IActionResult> addTouch(String touchtype, Int16 groupId, Int16 pnlid, String hexCbg, String hexClebel, decimal fntSize, Int16 linkfg, String linkcode, String pnllabel, String pnlimgurl)
        {

            try
            {
                if (!CheckExists(touchtype, groupId, pnlid))
                {
                    PsPanelItemButton addsh = new PsPanelItemButton();
                    addsh.TouchPanelType = touchtype;
                    addsh.GroupButtonId = groupId;
                    addsh.ItemButtonId = pnlid;
                    addsh.ItemButtonLabel = pnllabel;
                    addsh.ItemButtonImage = pnlimgurl;
                    addsh.LinkCodeFg = linkfg;
                    addsh.LinkCode = linkcode;
                    addsh.TxtColor = hexClebel;
                    addsh.BgColor = hexCbg;
                    addsh.TxtFontSize = fntSize;
                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPanelItemButtons.Add(addsh);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return NotFound();
                    }
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }
        [HttpPut("{p}/{id}/{touchtype}/{groupId}/{pnlid}")]
        public async Task<IActionResult> pasteButton(int id, String touchtype, Int16 groupId, Int16 pnlid)
        {

            try
            {

                PsPanelItemButton copysh = _context.PsPanelItemButtons.Where(item => item.Id == id).First();
                if (copysh != null)
                {

                    PsPanelItemButton addsh = new PsPanelItemButton();
                    if (!CheckExists(copysh.TouchPanelType, copysh.GroupButtonId, pnlid))
                    {
                        addsh.ItemButtonId = pnlid;
                    }
                    else {
                        addsh.ItemButtonId = CheckLasteExists(touchtype, groupId);
                        addsh.ItemButtonId += 1;
                    } 

                
                    addsh.TouchPanelType = touchtype;
                    addsh.GroupButtonId = groupId;
                    
                    addsh.ItemButtonLabel = copysh.ItemButtonLabel;
                    addsh.ItemButtonImage = copysh.ItemButtonImage;
                    addsh.LinkCodeFg = copysh.LinkCodeFg;
                    addsh.LinkCode = copysh.LinkCode;
                    addsh.TxtColor = copysh.TxtColor;
                    addsh.BgColor = copysh.BgColor;
                    addsh.TxtFontSize = copysh.TxtFontSize;
                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPanelItemButtons.Add(addsh);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return NotFound();
                    }

                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }
        [HttpPut("{u}/{id}/{hexCbg}/{hexClebel}/{fntSize}/{pnlid}/{linkfg}/{linkcode}/{pnllabel}/{pnlimgurl}")]
        public async Task<IActionResult> updateButton(int id,String hexCbg,String hexClebel,decimal fntSize, Int16 pnlid, Int16 linkfg, String linkcode, String pnllabel, String pnlimgurl)
        {

            try
            {
       
                    PsPanelItemButton addsh = _context.PsPanelItemButtons.Where(item => item.Id == id).First();
                if (addsh != null)
                {
                    if (!CheckExists(addsh.TouchPanelType, addsh.GroupButtonId, pnlid))
                    {
                        addsh.ItemButtonId = pnlid;
                    }
                        addsh.TxtColor = hexClebel;
                        addsh.BgColor = hexCbg;
                        addsh.TxtFontSize = fntSize;
                        addsh.LinkCode = linkcode;
                        addsh.ItemButtonImage = pnlimgurl;
                        addsh.ItemButtonLabel = pnllabel;
                        addsh.LinkCodeFg = linkfg;
                        addsh.UpdateBy = "Admin";
                        addsh.LastUpdate = DateTime.Now;

                        try
                        {
                            _context.PsPanelItemButtons.Update(addsh);
                            await _context.SaveChangesAsync();
                        }
                        catch (DbUpdateConcurrencyException)
                        {
                            return NotFound();
                        }
                  
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }
        [HttpPut("{d}/{id}")]
        public async Task<IActionResult> delTouch(int id)
        {

            try
            {
                     PsPanelItemButton addsh = _context.PsPanelItemButtons.Where(item => item.Id == id).First();

                      try
                    {
                        _context.PsPanelItemButtons.Remove(addsh);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        return NotFound();
                    }
              //  }
            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }
        private bool CheckExists(String touchtype, Int16 groupId, Int16 pnlid) =>
          _context.PsPanelItemButtons.Any(e => e.TouchPanelType == touchtype && e.GroupButtonId == groupId && e.ItemButtonId == pnlid);
        private Int16 CheckLasteExists(String touchtype, Int16 groupId) {
            try {
                return _context.PsPanelItemButtons.Where(a => a.TouchPanelType == touchtype && a.GroupButtonId == groupId).OrderByDescending(e => e.ItemButtonId).FirstOrDefault().ItemButtonId;
            } catch(NullReferenceException) {
                return Convert.ToInt16(0);
            }
          
        }
         
    }
}
