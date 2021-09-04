using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace A_Controller.Controllers
{
    // controller eklendiğinde Views klasörü içerinde controller isminde bir klasör oluşur. bunun neden buradaki actionların viewı bu klasörde aranacaktır. 
    public class YAYController : Controller
    {
        // GET: YAY
        public ActionResult Index()
        {
            // view metotu views klaösründe view rendender etmek için (kullanıcıya view dönmek) kullanılır... Bu metodunun dönüş tipi ViewResult'tır. bu metot eğer aksini belirtmezsek Metot isminde view arar..

            //return View(); // index isminde view döner
            return View("FormElements"); // formelements isminde view döner...
        }
    }
}