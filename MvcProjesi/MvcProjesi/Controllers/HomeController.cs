using MvcProjesi.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjesi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            return View();
        }

        //Son 5 makalenin ana sayfaya yükleneceği Action
        public ActionResult SonBesMakale()
        {
            //Veritabanından yeni bir nesne oluşturuyoruz.
            MvcProjesiContext db = new MvcProjesiContext();

            //Veritabanından sorgulamayı Linq ile yapıyoruz.
            //Tarih sırasına göre son makaleleri OrderByDescending ile çekip Take ile de 5 tane almasını istiyoruz.
            List<Makale> makaleListe = db.Makales.OrderByDescending(i => i.Tarih).Take(5).ToList();

            //Normal içeriklerde View döndürürken, burada ise PartialView döndürüyoruz.
            //Ayrıca makaleListe nesnesini de View'de kullanacağımız şekilde model olarak aktarıyoruz.
            return PartialView(makaleListe);
        }
    }
}