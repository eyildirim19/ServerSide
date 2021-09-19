using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace K_AjaxRequest.Controllers
{
    public class MvcAjaxRequestController : Controller
    {
        // GET: MvcAjaxRequest
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ornek1()
        {
            var response = new
            {
                Mesaj = "İşlem Başarılı",
                ResponseType = "Json",
                DurumKodu = "200"
            };

            return Json(response);
        }

        [HttpPost]
        public ActionResult Ornek2()
        {
            var response = new
            {
                Mesaj = "İşlem Başarılı",
                ResponseType = "Json",
                DurumKodu = "200"
            };

            return Json(response);
        }
    }
}