using appWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace appWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult index(String id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return View("Error");
            else
            {
                ViewData["id"] = id;
                return View("Index");
                
            }
        }

        public ActionResult chercherClient(string id)
        {
            Clients listeClient = new Clients();
            Client client = listeClient.LesClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
            {
                ViewData["nom"] = client.Nom;
                ViewData["age"] = client.Age;
                return View("Trouve");
            }
            else
                return View("Introuvable") ;
        }

        public ActionResult lesClients()
        {
            Clients listeClient = new Clients();
            ViewData["Clients"] =  listeClient.LesClients();
            if (listeClient != null)
                return View("AffichageClients");
            else
                return View("Introuvable");
        }
    }
}