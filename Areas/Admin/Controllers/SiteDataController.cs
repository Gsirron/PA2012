﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Prototype.Models;

namespace Prototype.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SiteDataController : Controller
    {

        private readonly PrototypeContext _context;

        public SiteDataController(PrototypeContext context)
        {
            context = _context;

        }
        // GET: SiteData
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SiteData/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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
    }
}