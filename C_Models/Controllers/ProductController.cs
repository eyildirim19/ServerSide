using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using C_Models.Models; // içeriisndeki sınıflara erişebilelim...
namespace C_Models.Controllers
{
    public class ProductController : Controller
    {
        MyContext dbContext; // sınıfta bir dbContenxt nesnesi oluşturduk
        public ProductController() // sınıfımızın yapıcı metodu...her requestten bu sınıftan oto instance alınır.. ve bu metot tetiklenir
        {
            dbContext = new MyContext(); // tetiklendiğinde instance al...
        }
        // ürünlerin listestelendiği action....
        public ActionResult Index()
        {
            // instance alınan dbcontext nesnesinden verileri çek..
            List<Urun> urunler = dbContext.Uruns.ToList();
            return View(urunler); // model olarak view'a gönder...
        }

        // ürünlerin gösterildiği action....
        public ActionResult Detay(int ID) // metot ID adına parametre bekler. bu parametre ile hangi ürün için tıklandığı biliriz....
        {
            // ID'ye göre ürünü buluyoruz....
            Urun urn = dbContext.Uruns.FirstOrDefault(c => c.ID == ID);

            return View(urn); // view model olarak gönderiyoruz...
        }
    }
}