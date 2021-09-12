using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace H_StateManagement.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {

            // saklanan cookie bulalım..

            HttpCookie kuk = Request.Cookies["kuk"];
            string val = "";
            if (kuk != null)
            {
                Session["tut"] = kuk.Value;
            }
            else
            {
                Session.Abandon(); // sessionı temizle
                Session.RemoveAll();
            }

            return View("Index");
        }

        public ActionResult KukiyeAt()
        {
            // Cookie Serverdan tarayıcıya atılan çerezlerdir.. Tarayıcıda belirtilen süre kadar veri saklanır. String tipinde veri saklanır...

            HttpCookie kuki = new HttpCookie("kuk"); // kuk isimli bir cookie oluşturduk...
            kuki.Value = "ben client side veri saklama yöntemiyim. Veriyi belirtilen süre zarfında saklarım...";
            kuki.Expires = DateTime.Now.AddMinutes(5); // kukinin saklama süresini  5 dakika olarak ayarla....

            Response.Cookies.Add(kuki); // kukiyi sakla

            return RedirectToAction("Index"); // geriye action dön....

        }
    }
}