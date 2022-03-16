using Odev3.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class HomeController : Controller
    {
        private calisanlarEntities db = new calisanlarEntities();
        [AllowAnonymous]
        public ActionResult anasayfa()
        {
            ViewBag.Title = "VENÜS";
            ViewBag.fotoğraflar = db.resim.ToList();
            return View(ViewBag.fotoğraflar);
        }

        public ActionResult dilDegistir(string lang, string returnUrl)
        {
            Session["Dil"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }

        
    }
}