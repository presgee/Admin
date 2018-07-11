using System.Web.Mvc;
using System.Web.Routing;

namespace ManageUser
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
           name: "Serial Number",
           url: "serialnumber/{lettercase}",
           defaults: new { controller = "Home", action = "SerialNumber", letterCase = "upper" }
       );

            routes.MapRoute(
         name: "AboutUs",
         url: "home/about-us/{id}",
         defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional }
     );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
