using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class KurtarmaController : Controller
    {
        // GET: Kurtarma
        [AllowAnonymous]
        public ActionResult kurtarma()
        {
            ViewBag.Title = "Kurtarma Sistemi";
            return View();
        }
    }
}