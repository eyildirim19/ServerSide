using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K_AjaxRequest.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Isimler()
        {
            List<string> isimler = new List<string>();
            isimler.Add("Ekrem");
            isimler.Add("Ferit");
            isimler.Add("Emre");

            return Json(isimler, JsonRequestBehavior.AllowGet); // Json metodu action mettottr. JsonResult Tipindedir. JsonRequesBehavior enumu (sabit) get requestlerden bu dataya erişebilir anlamındadır..
        }

        public ActionResult Kisiler()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi { Adi = "EKREM" });
            kisiler.Add(new Kisi { Adi = "FERİT" });
            kisiler.Add(new Kisi { Adi = "EMRE" });

            return Json(kisiler, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Kisi()
        {
            var obj = new Kisi { Adi = "EKREM" };
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
    public class Kisi
    {
        public string Adi { get; set; }
    }
}