using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class BasincController : Controller
    {
        [AllowAnonymous]
        // GET: Basinc
        public ActionResult basinc()
        {
            ViewBag.Title = "Basınç Sensörleri";
            return View();
        }
    }
}