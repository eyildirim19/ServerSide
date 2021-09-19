using K_AjaxRequestApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace K_AjaxRequestApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string SearchText)
        {
            Model1 dbContext = new Model1();
            // IsNullOrEmpty => stringin null veya boş olduğunu kontrol eder. eğer bunlardan birisi ise true döner
            List<Products> result = new List<Products>();
            if (!String.IsNullOrWhiteSpace(SearchText))
            {
                result = dbContext.Products.Where(c => c.ProductName.Contains(SearchText)).ToList();
            }

            return PartialView("_SearchResult", result);
        }

        public ActionResult Arama()
        {

            return View();
        }

        public ActionResult SearchWithJson(string SearchText)
        {
            Model1 dbContext = new Model1();
            dbContext.Configuration.ProxyCreationEnabled = false;

            // IsNullOrEmpty => stringin null veya boş olduğunu kontrol eder. eğer bunlardan birisi ise true döner
            List<Products> result = new List<Products>();
            if (!String.IsNullOrWhiteSpace(SearchText))
            {
                result = dbContext.Products.Where(c => c.ProductName.Contains(SearchText)).ToList();
            }

            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}