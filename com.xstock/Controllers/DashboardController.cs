using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.Mvc;
using Sunco.Models;
using System.Web.Configuration;
using MySql.Data.MySqlClient;
using Sunco.Context;
namespace Sunco.Controllers
{
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult index()
        {
            
           
           
            return Content("<div style='height:100vh;display:flex;justify-content:center;align-items:center;'><b>Sunco Web Services</b></div>");
        }

    }
}
