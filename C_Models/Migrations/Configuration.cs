namespace C_Models.Migrations
{
    using C_Models.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<C_Models.Models.MyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(C_Models.Models.MyContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            // seet metodu bu metot update-database ile çalışır.. buradan veritabanına default veri ekleyebilirsiniz...

            Urun u = new Urun();
            u.Adi = "Casper Excalibur G770.1030-8DH0T i5-10300H 8GB RAM 240GB SSD GTX1650 4GB 15,6' Notebook";
            u.Fiyat = 7000;
            u.EskiFiyat = 5000;
            u.ImagePath = "images/1.png";

            Urun u1 = new Urun();
            u1.Adi = "Lenovo Ideapad 3 81WQ002TTX Intel Celeron N4020 4GB Ram 128GB Ssd Intel UHD Graphics 600 15.6' W10 Notebook Siyah";
            u1.Fiyat = 5000;
            u1.EskiFiyat = 6000;
            u1.ImagePath = "images/2.jpg";


            Urun u2 = new Urun();
            u2.Adi = "Hp 308U8EA All in One 24DP0041NT i3 10100T 8GB 256GB SSD MX330 2gb 23.8' W10h";
            u2.Fiyat = 5000;
            u2.EskiFiyat = 6000;
            u2.ImagePath = "images/3.jpg";

            Urun[] uruns = new Urun[3];
            uruns[0] = u;
            uruns[1] = u1;
            uruns[2] = u2;

            context.Uruns.AddOrUpdate(uruns); // yoksa ekle varsa güncelle. çünkü sürekli seed metodu çalışak. add dersek sürekli ekler...
        }
    }
}
