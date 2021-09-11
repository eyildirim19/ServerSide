using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace F_LayoutPages.Controllers
{
    public class HomeController : Controller
    {
        /*
         * views klasörüne sağ tık yapıp add new folder ile shared isimli bir  klasörü ekliyoruz. bu klasöre sağ tık yapıp add view ile bir view ekliyoruz...  
        */
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anasayfa()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
    }
}