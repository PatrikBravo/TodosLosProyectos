using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRazor.Controllers
{
    public class pruebasController : Controller
    {
        // GET: pruebas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ciclos()
        {
            return View();
        }
    }
}