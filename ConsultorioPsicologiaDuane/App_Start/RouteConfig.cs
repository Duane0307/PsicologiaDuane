using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ConsultorioPsicologiaDuane
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
            name: "ConsultarDados",
            url: "HomeController/ConsultarDados",
            defaults: new { controller = "HomeController", action = "ConsultarDados" }
        );

            routes.MapRoute(
  name: "CadastrarPaciente",
  url: "HomeController/CadastrarPaciente",
  defaults: new { controller = "HomeController", action = "CadastrarPaciente" }
);

            routes.MapRoute(
name: "ExcluirRegistro",
url: "HomeController/ExcluirRegistro",
defaults: new { controller = "HomeController", action = "ExcluirRegistro", id = UrlParameter.Optional }
);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
