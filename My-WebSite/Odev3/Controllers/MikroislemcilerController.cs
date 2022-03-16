using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class MikroislemcilerController : Controller
    {
        // GET: Mikroislemciler
        [AllowAnonymous]
        public ActionResult mikroislemciler()
        {
            ViewBag.Title = "Mikroişlemciler";
            return View();
        }
    }
}