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
    public class TouchPanelController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public TouchPanelController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<PsPosTouchPanelType> Get()
        {
            return _context.PsPosTouchPanelTypes.AsEnumerable();

        }
        [HttpGet("{touchtype}")]
        public IEnumerable<PsPosTouchPanelType> GetACode(String touchtype)
        {
            return _context.PsPosTouchPanelTypes.Where(a => a.TouchPanelType == touchtype).AsEnumerable();

        }

        [HttpPut("{a}/{touchtype}/{screenType}/{touchname}")]
        public async Task<IActionResult> addTouch(String touchtype, String screenType, String touchname)
        {

            try
            {
                if (!CheckExists(touchtype))
                {
                    PsPosTouchPanelType addsh = new PsPosTouchPanelType();
                    addsh.TouchPanelType = touchtype;
                    addsh.TouchPanelDesc = touchname;
                    addsh.POSScreenType = screenType;
                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPosTouchPanelTypes.Add(addsh);
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
        [HttpPut("{u}/{e}/{id}/{screenType}/{touchtype}/{touchname}")]
        public async Task<IActionResult> updateTouch(int id, String screenType, String touchtype, String touchname)
        {

            try
            {
                PsPosTouchPanelType addsh = _context.PsPosTouchPanelTypes.Where(item => item.Id == id).First();
                if (addsh != null)
                {
                    if (!CheckExists(touchtype))
                    {
                        addsh.TouchPanelType = touchtype;
                    }
                    addsh.TouchPanelDesc = touchname;
                    addsh.POSScreenType = screenType;
                    
                    addsh.UpdateBy = "Admin";
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPosTouchPanelTypes.Update(addsh);
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
        [HttpPut("{d}/{touchtype}")]
        public async Task<IActionResult> delTouch(String touchtype)
        {

            try
            {
                if (CheckExists(touchtype))
                {
                    PsPosTouchPanelType addsh = _context.PsPosTouchPanelTypes.Where(e => e.TouchPanelType == touchtype).First();
                   

                    try
                    {
                        _context.PsPosTouchPanelTypes.Remove(addsh);
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
        private bool CheckExists(string tt) =>
          _context.PsPosTouchPanelTypes.Any(e => e.TouchPanelType == tt);
    }
}
