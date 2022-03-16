using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev3.Controllers
{
    public class Haber2Controller : Controller
    {
        // GET: Haber2
        [Authorize]
        public ActionResult haber2()
        {
            ViewBag.Title = "Roketsan'ın TEKNOFEST kapsamındaki Roket Yarışması'nın kazananları belli oldu";
            return View();
        }
    }
}