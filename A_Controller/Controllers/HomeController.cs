using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Controller.Controllers
{

    // Controller => denetleyici => yapılan requestleri(istekleri) denetler.  Burada view veya viewmodel döner... Controller gelen requesti filtreler ve actionlara yönlendirilir. actionlar (metot) son kullanıcıya belirttiğimiz şekilde döner..

    // Kural mvc'de url kısmından sayfa çağrılmaz. url'den controller içerisindeki action çağrılır. Viewlar hazırlanır ve action tarafndan render edilir. (çıktı olarak üretilir...)..

    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(); // view render eder..
        }

        // action eğer view dönüyorsa metot ismine sağ tık yapıp add view diyebilirsiniz. Gelen pencerede name kısmında metot adı yazacaktır ve o metot adı ile .cshtml dosyası oluşturulacaktır.
        public ActionResult BizimSayfamiz()
        {
            return View();
        }

        public string MesajVer()
        {
            return "Merhaba MVC";
        }

        public int Topla()
        {
            return 50 + 1;
        }
    }
}