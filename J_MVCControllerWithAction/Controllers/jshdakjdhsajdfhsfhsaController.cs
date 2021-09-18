using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J_MVCControllerWithAction.Controllers
{
    public class jshdakjdhsajdfhsfhsaController : Controller
    {
        // GET: jshdakjdhsajdfhsfhsa
        public ActionResult Index()
        {
            return View();
        }

        // GET: jshdakjdhsajdfhsfhsa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: jshdakjdhsajdfhsfhsa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: jshdakjdhsajdfhsfhsa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
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

        // GET: jshdakjdhsajdfhsfhsa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: jshdakjdhsajdfhsfhsa/Edit/5
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

        // GET: jshdakjdhsajdfhsfhsa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: jshdakjdhsajdfhsfhsa/Delete/5
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
