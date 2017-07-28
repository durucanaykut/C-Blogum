//Veritabanı context sınıfımızı referans veriyoruz
using MvcProjesi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcProjesi
{
    public class MvcApplication : System.Web.HttpApplication
    {
        //Uygulama ilk başlatıldığında, buradaki metod çalışacak.
        protected void Application_Start()
        {
            //Burada veritabanı sınıfımızdan, bir nesne oluşturuyoruz. using kullanmamızın sebebi,
            //db nesnesinin işi bittiğinde, silinmesini ve hafızada yer tutmamasını sağlamak.
            using (MvcProjesiContext db = new MvcProjesiContext())
            {
                //Bu metod, eğer veritabanımız oluşturulmamış ise, oluşturulmasını sağlıyor.
                db.Database.CreateIfNotExists();

                /* Bir kere makaleleri ekledikten sonra, her seferinde tekrar 
                 * eklenmemesi için yorum satırı haline getirdik.
                //Buraya örnek olması açısından 6 adet makale ekleyelim.
 
                //Makaleden bir nesne oluşturuyoruz.
                Makale makale = new Makale();
                makale.Baslik = "Makale Başlığı 1";
                makale.Icerik = "Makale İçeriği 1";
                //Tarih olarak, şu anki tarihi veriyoruz.
                makale.Tarih = DateTime.Now;
 
                //Aynı işlemi diğer makaleler için de tekrarlıyoruz.
                //Bu sefer daha kısa tanımlama yöntemini kullandık.
                Makale makale2 = new Makale() { Baslik = "Makale Başlığı 2", Icerik = "Makale İçeriği 2", Tarih = DateTime.Now };
                Makale makale3 = new Makale() { Baslik = "Makale Başlığı 3", Icerik = "Makale İçeriği 3", Tarih = DateTime.Now };
                Makale makale4 = new Makale() { Baslik = "Makale Başlığı 4", Icerik = "Makale İçeriği 4", Tarih = DateTime.Now };
                Makale makale5 = new Makale() { Baslik = "Makale Başlığı 5", Icerik = "Makale İçeriği 5", Tarih = DateTime.Now };
                Makale makale6 = new Makale() { Baslik = "Makale Başlığı 6", Icerik = "Makale İçeriği 6", Tarih = DateTime.Now };
 
                //Veritabanında ki Makalelere eklemek için ekleme komutu veriyoruz.
                //SaveChanges() komutu gelene kadar veritabanına kaydedilmeyecek.
                db.Makales.Add(makale);
                db.Makales.Add(makale2);
                db.Makales.Add(makale3);
                db.Makales.Add(makale4);
                db.Makales.Add(makale5);
                db.Makales.Add(makale6);
 
                //Son olarak ta yaptığımız eklemelerin, veritabanına yansıtılmasını
                //sağlamak için kaydet komutu veriyoruz.
                db.SaveChanges();
                 */
            }
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}