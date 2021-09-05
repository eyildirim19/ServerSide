using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using C_ModelsApp.Models;

namespace C_ModelsApp.Controllers
{
    public class HomeController : Controller
    {
        BlogDbContext dbContext;
        public HomeController()
        {
            dbContext = new BlogDbContext();
        }

        // GET: Home
        public ActionResult Index()
        {
            List<Makale> makaleler = dbContext.Makale.ToList();
            return View(makaleler);
        }

        public ActionResult MakaleDetay(int Id)
        {
            Makale mak = dbContext.Makale.FirstOrDefault(c => c.ID == Id);
            return View(mak);
        }


        // Aynı isimde iki action olduğu için bunlardan hangisi request atıldığında çalışacak. Actionların biri view göstermek için diğeri viewdan veri almak için oluşturuldu. Bunlarıda komut ile belitmemiz gerekiyor... bir actiona default atılan request tipi get'tir.

        // View gösterir...
        public ActionResult AddYorum(int Id)
        {
            Yorum yor = new Yorum();
            yor.MakaleID = Id;


            return View(yor);
        }

        // Parametre olarak yorum tipinde model bekler. View taraında input isimlerimiz propertylerimiz ile eşleceği için model otomatik viewdan gönderildiğigibi  gelir....

        [HttpPost] // => bu atribute bu actionın sadece post requestlerde çalışacağını gösterir...
        public ActionResult AddYorum(Yorum model)
        {
            model.Tarih = DateTime.Now;

            dbContext.Yorum.Add(model);
            dbContext.SaveChanges();

            // viewdan gönderilen yorumun makaleIdsini RedirecToAction metodu ile Parametre olarak gönderiyoruz....

            // geriye action dönsün....
            return RedirectToAction("MakaleDetay", new { Id = model.MakaleID });
        }
    }
}