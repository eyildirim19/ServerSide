using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using C_Models.Models;

namespace C_Models.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "KAAN";
            ogr.SoyAdi = "MEŞE";
            ogr.ID = 1;

            return View(ogr);// ogr nesnemizi view'a model olarak gönderdik...
        }

        public ActionResult Ogrencilerim()
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = "KAAN";
            ogr.SoyAdi = "MEŞE";
            ogr.ID = 1;

            Ogrenci ogr1 = new Ogrenci();
            ogr1.Adi = "EMRE";
            ogr1.SoyAdi = "KAYAOĞLU";
            ogr1.ID = 2;

            List<Ogrenci> ogrencis = new List<Ogrenci>();
            ogrencis.Add(ogr);
            ogrencis.Add(ogr1);

            return View(ogrencis);
        }

        
        

    }
}