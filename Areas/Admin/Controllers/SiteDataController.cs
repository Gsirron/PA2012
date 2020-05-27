using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language;
using Microsoft.EntityFrameworkCore;
using Prototype.Migrations;
using Prototype.Models;


namespace Prototype.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteDataController : Controller
    {

        private readonly PrototypeContext _context;

        public SiteDataController(PrototypeContext context)
        {
            
            _context = context;
  

        }
        // GET: SiteData

        public async Task<IActionResult> Index()
        {

            var SiteData = from s in _context.SiteData
                           select s;


            return View(await SiteData.ToListAsync());
        }
        // GET: SiteData/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SiteData/Create
        public ActionResult Create()
        {
            return View();
        }

        public async Task<IActionResult> ChangePhase()
        {
            var SiteData = from s in _context.SiteData
                           select s;
            
            return View(await SiteData.ToListAsync());

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task ChangePhaseFalse()
        {
            var SiteData2 = from s in _context.SiteData
                            select s;

            SiteData2 = SiteData2.Where(s => s.SiteData_Active == true);

            if (SiteData2 == null)
            {
                return;
            }

            foreach (var item in SiteData2)
            {
                item.SiteData_Active = false;
            }

            try
            {
                _context.UpdateRange(SiteData2);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SiteDataExits(SiteData2))
                {
                    return;
                }
                else
                {
                    throw;
                }
            }
            return;
           

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePhase(int id)
        {
            

            var sitedata = await _context.SiteData.FindAsync(id);

            if (sitedata == null)
            {
                return NotFound();
            }
            await ChangePhaseFalse();
            sitedata.SiteData_Active = true;

            try
            {
                _context.Update(sitedata);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                
                if (!SiteDataExits(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToAction(nameof(ChangePhase));
        }
        

        // POST: SiteData/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SiteData/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var SiteData = await _context.SiteData.FindAsync(id);

            if(SiteData ==null)
            {
                return NotFound();
            }

            return View(SiteData);
        }

        // POST: SiteData/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("SiteDataId", "SiteData_Name","SiteData_Link")]SiteData sitedata)
        {
            if (id != sitedata.SiteDataId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                var OldSiteData = await _context.SiteData.FindAsync(id);

                OldSiteData.SiteData_Link = sitedata.SiteData_Link;
                OldSiteData.SiteData_Name = sitedata.SiteData_Name;
                try
                {
                    // TODO: Add update logic here
                    _context.Update(OldSiteData);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SiteDataExits(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                };
                
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: SiteData/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SiteData/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        private bool SiteDataExits(int id)
        {
            return _context.SiteData.Any(e => e.SiteDataId == id);
        }

        private bool SiteDataExits(IEnumerable<SiteData> sitedata)
        {
            foreach (var item in sitedata)
            {
                return _context.SiteData.Any(e => e.SiteDataId == item.SiteDataId);
            }

            return false;
        }
    }
}