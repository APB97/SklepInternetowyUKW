using System.Web.Mvc;
using System.Web.Routing;

namespace Sklep
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "StaticSite",
                url: "sites/{name}.html",
                defaults: new { controller = "Home", action = "StaticSite" }
            );

            routes.MapRoute(
                name: "FilmsList",
                url: "category/{categoryName}",
                defaults: new { controller = "Films", action = "List" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
