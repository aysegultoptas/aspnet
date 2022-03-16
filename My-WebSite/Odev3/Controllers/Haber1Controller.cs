using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class Haber1Controller : Controller
    {
        // GET: Haber1
        [Authorize]
        public ActionResult haber1()
        {
            ViewBag.Title= "SpaceX, NASA'nın 'Crew - 3' astronotlarını Uluslararası Uzay İstasyonuna ulaştırdı!";
            return View();
        }
    }
}