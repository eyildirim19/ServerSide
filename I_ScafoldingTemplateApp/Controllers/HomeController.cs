using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using I_ScafoldingTemplateApp.Models;

namespace I_ScafoldingTemplateApp.Controllers
{
    public class HomeController : Controller
    {
        BtAkademiDbContext db;
        public HomeController()
        {
            db = new BtAkademiDbContext();
        }

        public ActionResult Index()
        {
            List<Ogrenci> ogrenciler = db.Ogrencis.ToList();
            return View(ogrenciler);
        }

        public ActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Ekle(Ogrenci model)
        {
            db.Ogrencis.Add(model); // formdan gelen veriyi veritabanına ekle
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int Id)
        {
            //Ogrenci ogr = db.Ogrencis.FirstOrDefault(c => c.ID == Id);
            Ogrenci ogr = db.Ogrencis.Find(Id);
            return View(ogr);
        }

        [HttpPost]
        public ActionResult Duzenle(Ogrenci model)
        {
            Ogrenci o = db.Ogrencis.Find(model.ID);
            o.Adi = model.Adi;
            o.SoyAdi = model.SoyAdi;
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Sil(int Id)
        {
            Ogrenci o = db.Ogrencis.Find(Id);
            db.Ogrencis.Remove(o);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}