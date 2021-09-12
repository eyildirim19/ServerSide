using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H_StateManagement.Controllers
{

    // session serverda veri saklama yöntemidir. sayfa sıfırlanırken sessionda kaybolmasını istemediğimiz verilerimizi tutarız. 
    public class HomeController : Controller
    {
        int sayac = 0;
        // GET: Home
        public ActionResult Index()
        {
            return View(sayac);
        }

        public ActionResult Arttir()
        {
            // web sayfalarındaki login işlemleri vb. veriler sessionda saklalanır...

            // sessionlar key value mantığında çalışırlar..veriyi belirli süre servarda geçici olarak saklarlar...

            if (Session["s"] != null) // session oluşturulmuşsa
            {
                sayac = (int)Session["s"]; // sessionda veriyi çıkart
            }

            sayac++;

            // sessiona değer atalım..
            Session["s"] = sayac; // s adında bir session oluşturduk ve sayac değişkenin değerini atadık...

            return View("Index", sayac); // index viewımı dön, model olarak artan sayacı gönder....
        }
    }
}