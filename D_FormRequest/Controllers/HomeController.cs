using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace D_FormRequest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        // Eğer bir actiona request yapılırken yapılan request post ise actionda da belirtilmelidir. yoksa url kısmından get request yapılıp güvenlik problemi oluşabilir...Bunun önüne HttpPost attribute ile geçiriz. Actionda bu attribute varsa action sadece post requestleri kabul edecektir..

        // Parametre isimlerin formdan gelen control isimleriyle aynı olursa veriler alınabilir....
        [HttpPost]
        public ActionResult Request1(string Adi, string Soyadi)
        {
            string fullAd = Adi + " " + Soyadi;
            return View();
        }

        // FormCollection parametresi ile formda gelen veriler yakalanabilir...FormCollection request yapılan formu array olarak kabul eder..
        [HttpPost]
        public ActionResult Request2(FormCollection c)
        {
            string adi = c["Adi"];
            string sadi = c["Soyadi"];

            return View();
        }

        [HttpPost]
        public ActionResult Request3()
        {
            // Request.Form ile formdan gelen veriler yakalanabilir...
            string adi = Request.Form["Adi"];
            string sadi = Request.Form["Soyadi"];

            return View();
        }

        [HttpPost]
        public ActionResult Request4(Request4Model model)
        {
            return View();
        }
    }

    //Bu sınıf viewModel için oluşturuldu. Eğer içerisindeki üyelerinin adı ile formdan gelen control isimleir aynı olurrsa verilere erişelebilir...

    public class Request4Model
    {
        public string Adi { get; set; }

        public string Soyadi { get; set; }
    }
}