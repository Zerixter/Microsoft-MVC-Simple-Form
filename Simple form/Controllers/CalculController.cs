using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simple_form.Controllers
{
    public class CalculController : Controller
    {
        // GET: Calcul
        public ActionResult Index()
        {
            return View();
        }

        [Route("suma"), HttpGet]
        public ActionResult Suma()
        {
            return View();
        }

        [Route("suma"), HttpPost]
        public ActionResult Suma(int numero1, int numero2)
        {

            ViewBag.Resultat = string.Format("El resultat de {0} + {1} = {2}",
                                              numero1, numero2, numero1 + numero2);
            return View();
        }
    }
}