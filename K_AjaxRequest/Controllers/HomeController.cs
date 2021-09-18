using K_AjaxRequest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K_AjaxRequest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //List<Urun> urns = new List<Urun>();
            //urns.Add(new Urun { Adi = "A Ürünü", Fiyat = 1000 });
            //urns.Add(new Urun { Adi = "B Ürünü", Fiyat = 2000 });
            //urns.Add(new Urun { Adi = "C Ürünü", Fiyat = 3000 });
            //return View(urns);

            return View(Urunlerim()); // view'a model olarak gönder...
        }


        List<Urun> Urunlerim()
        {
            List<Urun> urns = new List<Urun>();
            urns.Add(new Urun { Adi = "A Ürünü", Fiyat = 1000 });
            urns.Add(new Urun { Adi = "B Ürünü", Fiyat = 2000 });
            urns.Add(new Urun { Adi = "C Ürünü", Fiyat = 3000 });
            return urns;
        }

        [HttpPost]
        public ActionResult Kaydet()
        {
            //List<Urun> urns = new List<Urun>();
            //urns.Add(new Urun { Adi = "A Ürünü", Fiyat = 1000 });
            //urns.Add(new Urun { Adi = "B Ürünü", Fiyat = 2000 });
            //urns.Add(new Urun { Adi = "C Ürünü", Fiyat = 3000 });
            //return View("Index", urns);

            return View("Index", Urunlerim());
        }
    }
}