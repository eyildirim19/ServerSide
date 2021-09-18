using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J_MVCControllerWithAction.Controllers
{

    public class MyClass
    {
        [Required] // Zorunlu alan...
        public string Name { get; set; }

        public string SurName { get; set; }

        [Required] // Zorunlu alan...
        public string Password { get; set; }

        public string Password2 { get; set; }
    }

    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Kaydet()
        {
            return View();
        }

        //Bind attributesi formdan gelecek alanları bind eder... eğer bind attribute belirtilmezse formdaki bütün alanlar gelir. belirtilirse sadece belirtilen alanlar gelir...

        [HttpPost]
        // Not : [Bind(Include = "Name")] attriubete güvenlik attributesidir. Güvenlik taramalarında güvenlik açığı olarak çıkacaktır. heer zaman kullanılması tavsitye edilir...

        public ActionResult Kaydet([Bind(Include = "Name")]MyClass myClass)
        {
            bool ValidationYapildiMi = ModelState.IsValid;


            return View();
        }
    }
}