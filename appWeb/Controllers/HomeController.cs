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
        public ActionResult Index(String id)
        {
            if (String.IsNullOrWhiteSpace(id))
                return View("Error");
            else
            {
                ViewData["id"] = id;
                return View("Index");
                
            }
        }

        public String ChercherClient(string id)
        {
            Clients listeClient = new Clients();
            Client client = listeClient.LesClients().FirstOrDefault(c => c.Nom == id);
            if (client != null)
                return client.Nom;
            else
                return "pas trouvé !";
        }
    }
}