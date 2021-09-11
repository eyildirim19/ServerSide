using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace G_PartialViews.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ViewResult Index()
        {
            return View(); // by metodun dönüş tipi ViewResulttır.
        }

        public PartialViewResult Action1()
        {

            return PartialView("BenimSayfam"); // Bu metodun dönüş tpi PartilViewResulttır..
        }

        // Not : actionResult bütün hepsinin atası olduğu için ActionResult dönüştipli metot tanımlamak yeterlidir..sadece gövdede ne döneceğine karar veriniz..

        public ActionResult Eksın()
        {
            return PartialView("View");
        }

        public ActionResult Ogrenciler()
        {
            string isim = "Ekrem";
            return PartialView("_ogrenciTemplate", isim);
        }
    }
}