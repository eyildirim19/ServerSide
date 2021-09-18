using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using J_MVCControllerWithAction.Models;

namespace J_MVCControllerWithAction.Controllers
{
    public class OgrencisController : Controller
    {
        private Model1 db = new Model1();

        // GET: Ogrencis
        public ActionResult Index()
        {
            return View(db.Ogrencis.ToList());
        }

        // GET: Ogrencis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest); // kötü istek...
            }

            Ogrencis ogrencis = db.Ogrencis.Find(id);
            if (ogrencis == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound); // kaynak bulanamadı...
                //return HttpNotFound();
            }
            return View(ogrencis);
        }

        // GET: Ogrencis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ogrencis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Adi,SoyAdi")] Ogrencis ogrencis)
        {
            if (ModelState.IsValid) // doğrulama yaptıysa.....
            {
                db.Ogrencis.Add(ogrencis);
                db.SaveChanges();
                return RedirectToAction("Index"); // Index actiona yönlendir...
            }

            return View(ogrencis);
        }

        // GET: Ogrencis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrencis ogrencis = db.Ogrencis.Find(id);
            if (ogrencis == null)
            {
                return HttpNotFound();
            }
            return View(ogrencis);
        }

        // POST: Ogrencis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken] // 
        public ActionResult Edit([Bind(Include = "ID,Adi,SoyAdi")] Ogrencis ogrencis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogrencis).State = EntityState.Modified; // veritabanından güncellenen alanları güncelle...
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogrencis);
        }

        // GET: Ogrencis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogrencis ogrencis = db.Ogrencis.Find(id);
            if (ogrencis == null)
            {
                return HttpNotFound();
            }
            return View(ogrencis);
        }

        // POST: Ogrencis/Delete/5

        // ActionName => actiona çağrılırken farklı isim verilmesini sağlayacaktır. Örneğimizde DelefeConfirmed actionı uygulama içerisinden Delete ismi ile çağrılacaktır...
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogrencis ogrencis = db.Ogrencis.Find(id);
            db.Ogrencis.Remove(ogrencis);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
