
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Sunco.Routes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("dashboard","",new {controller="Dashboard", action="index"});
        }
    }

}