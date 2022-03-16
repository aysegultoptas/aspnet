using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class MekanikController : Controller
    {
        // GET: Mekanik
        [AllowAnonymous]
        public ActionResult mekanik()
        {
            ViewBag.Title = "Mekanik Sistem";
            return View();
        }
    }
}