using I_ScafoldingTemplates.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace I_ScafoldingTemplates.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new Ogrenci { Adi = "A", Email = "a@a.com", SoyAdi = "b", ID = 1 });
            ogrenciler.Add(new Ogrenci { Adi = "B", Email = "b@a.com", SoyAdi = "b", ID = 2 });
            ogrenciler.Add(new Ogrenci { Adi = "C", Email = "c@a.com", SoyAdi = "b", ID = 3 });

            return View(ogrenciler);
        }

        public ActionResult Create()
        {

            return View();
        }
    }
}