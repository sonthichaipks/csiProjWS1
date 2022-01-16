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
    public class GrpPnlController : ControllerBase
    {
        private readonly csiGenizPOSContext _context;

        public GrpPnlController(csiGenizPOSContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<PsPanelGroupButton> Get()
        {
            return _context.PsPanelGroupButtons.AsEnumerable();

        }
        [HttpGet("{touchtype}")]
        public IEnumerable<PsPanelGroupButton> GetACode(String touchtype)
        {
            return _context.PsPanelGroupButtons.Where(a => a.TouchPanelType == touchtype).OrderBy(e=>e.GroupButtonId).AsEnumerable();

        }

        [HttpPut("{a}/{touchtype}/{groupId}/{hexCbg}/{hexClebel}/{fntSize}/{grouplabel}/{groupimgurl}")]
        public async Task<IActionResult> addTouch(String touchtype, Int16 groupId, String hexCbg, String hexClebel, decimal fntSize, String grouplabel,  String groupimgurl)
        {

            try
            {
                if (!(CheckExists(touchtype, groupId)))
                {
                    PsPanelGroupButton addsh = new PsPanelGroupButton();
                    addsh.TouchPanelType = touchtype;
                    addsh.GroupButtonId = groupId;
                    addsh.GroupButtonLabel = grouplabel;
                    addsh.GroupButtonImage = groupimgurl;
                    addsh.TxtColor = hexClebel;
                    addsh.BgColor = hexCbg;
                    addsh.TxtFontSize = fntSize;
                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPanelGroupButtons.Add(addsh);
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
        [HttpPut("{p}/{id}/{touchtype}/{groupId}")]
        public async Task<IActionResult> pasteButton(int id, String touchtype, Int16 groupId)
        {

            try
            {

                PsPanelGroupButton copysh = _context.PsPanelGroupButtons.Where(item => item.Id == id).First();
                if (copysh != null)
                {

                    PsPanelGroupButton addsh = new PsPanelGroupButton();
                    if (!CheckExists(copysh.TouchPanelType, groupId))
                    {
                        addsh.GroupButtonId = groupId;
                    }
                    else
                    {
                        addsh.GroupButtonId = CheckLasteExists(touchtype);
                        addsh.GroupButtonId += 1;
                    }


                    addsh.TouchPanelType = touchtype;
                  
                    addsh.GroupButtonLabel = copysh.GroupButtonLabel;
                    addsh.GroupButtonImage = copysh.GroupButtonImage;
                    addsh.TxtColor = copysh.TxtColor;
                    addsh.BgColor = copysh.BgColor;
                    addsh.TxtFontSize = copysh.TxtFontSize;
                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPanelGroupButtons.Add(addsh);
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

        [HttpPut("{s}/{touchtype}/{u}")]
        public async Task<IActionResult> sortButton(String touchtype)
        {

            try
            {
                Int16 startId = 0;
                IEnumerable<PsPanelGroupButton> list = _context.PsPanelGroupButtons.Where(a => a.TouchPanelType == touchtype).OrderBy(e => e.GroupButtonLabel).AsEnumerable();
                foreach (var addsh in list)
                {
                   
                    startId += 1;
                    addsh.GroupButtonId = startId;

                    addsh.UpdateBy = "Admin";
                    addsh.CreateBy = "Admin";
                    addsh.CreateDate = DateTime.Now;
                    addsh.LastUpdate = DateTime.Now;
                    _context.PsPanelGroupButtons.Update(addsh);


                };
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateConcurrencyException)
            {
                return NotFound();
            }


            return NoContent();

        }
        [HttpPut("{u}/{e}/{id}/{touchtype}/{groupId}/{hexCbg}/{hexClebel}/{fntSize}/{grouplabel}/{groupimgurl}")]
        public async Task<IActionResult> updateButton(int id, String touchtype, Int16 groupId, String hexCbg,  String hexClebel, decimal fntSize, String grouplabel, String groupimgurl)
        {

            try
            {

                PsPanelGroupButton addsh = _context.PsPanelGroupButtons.Where(item => item.Id == id).First();
                if (addsh != null)
                {

                    if (!CheckExists(addsh.TouchPanelType, groupId))
                    {
                        addsh.GroupButtonId = groupId;
                    }

                    addsh.TxtColor = hexClebel;
                    addsh.BgColor = hexCbg;
                    addsh.TxtFontSize = fntSize;
                    
                    addsh.GroupButtonImage = groupimgurl;
                    addsh.GroupButtonLabel = grouplabel;
                   
                    addsh.UpdateBy = "Admin";
                    addsh.LastUpdate = DateTime.Now;

                    try
                    {
                        _context.PsPanelGroupButtons.Update(addsh);
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
               
                    PsPanelGroupButton addsh = _context.PsPanelGroupButtons.Where(item => item.Id == id).First();


                    try
                    {
                        _context.PsPanelGroupButtons.Remove(addsh);
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
        private bool CheckExists(String touchtype, Int16 groupId) =>
          _context.PsPanelGroupButtons.Any(e => e.TouchPanelType == touchtype && e.GroupButtonId == groupId);
        private Int16 CheckLasteExists(String touchtype)
        {
            try
            {
                return _context.PsPanelGroupButtons.Where(a => a.TouchPanelType == touchtype).OrderByDescending(e => e.GroupButtonId).FirstOrDefault().GroupButtonId;
            }
            catch (NullReferenceException)
            {
                return Convert.ToInt16(0);
            }

        }
      
    }
}
