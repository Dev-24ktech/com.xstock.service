
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Sunco.Routes;
namespace Sunco
{


    public class SuncoLedWebService : HttpApplication
    {
        
        //This call back method will call when application start
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}