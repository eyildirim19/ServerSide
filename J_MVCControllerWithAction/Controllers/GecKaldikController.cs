using J_MVCControllerWithAction.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J_MVCControllerWithAction.Controllers
{
    public class GecKaldikController : Controller
    {
        Model1 dbcontext;
        // GET: GecKaldik
        public ActionResult Index()
        {
            dbcontext = new Model1();
            
            var result = dbcontext.Ogrencis.ToList();
            return View(result);
        }

        // GET: GecKaldik/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GecKaldik/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GecKaldik/Create
        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GecKaldik/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: GecKaldik/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: GecKaldik/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: GecKaldik/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
