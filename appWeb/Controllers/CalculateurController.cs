using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appWeb.Controllers
{
    public class CalculateurController : Controller
    {
        // GET: Calculateur
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Ajouter(int valeur1, int valeur2)
        {
            int res = valeur1 + valeur2;
            ViewData["res"] = res;
            return View("Index");
        }

        public ActionResult AjouterInfini(string valeur)
        {
            ViewData["res"] = valeur;
            return View("Index");
        }

    }
}