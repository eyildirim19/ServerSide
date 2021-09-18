using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K_AjaxRequest.Controllers
{
    public class JsonAppController : Controller
    {
        // GET: JsonApp
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kayit()
        {
            Result r = new Result();
            r.Mesaj = "İşlem başarılı";

            return Json(r, JsonRequestBehavior.AllowGet);
        }
    }

    public class Result
    {
        public string Mesaj { get; set; }
    }

    public enum Denem
    {
        A,
        B,
        C
    }
}