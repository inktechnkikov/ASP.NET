using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspIntroduction.Controllers
{
    public class EmtyTestController : Controller
    {
        // GET: EmtyTest

        public ActionResult Index()
        {
            return View();
        }
    }
}