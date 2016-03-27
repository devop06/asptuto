using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace appWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "Calcul",
            url: "Calculateur/{action}/{valeur1}/{valeur2}",
            defaults: new { controller = "Calculateur", action = "Ajouter", valeur1 = 0, valeur2 = 0 },
            constraints: new { valeur1 = @"\d+", valeur2= @"\d+"}

            );

            routes.MapRoute(
            name: "Calcul2",
            url: "Ajouter/{*valeur}", // permet d'avoir paramètre infini dans l'url
            defaults: new { controller = "Calculateur", action = "AjouterInfini", valeur = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

           

         
        }
    }
}
