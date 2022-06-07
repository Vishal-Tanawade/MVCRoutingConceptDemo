using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCRoutingConceptDemo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes(); //This line added to enable attribute routing
            //http://localhost:55203/MyController/MyCustomer

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "CustomerList",  //Name should be unique for each route
                url:"CustomerPortal",  
                defaults: new{controller="Customer",action="Index" });


            routes.MapRoute(
                name: "CustomerAdd",  //Name should be unique for each route
                url: "CustomerPortal/Register",
                defaults: new { controller = "Customer", action = "AddCustomer" });
          
            routes.MapRoute(
               name: "CustomerDetails",  //Name should be unique for each route
               url: "CustomerPortal/knowYourCustomer",
               defaults: new { controller = "Customer", action = "CustomerDetails" });

            routes.MapRoute(
              name: "CustomerDetailsWithParaID",
              url: "CustomerPortal/knowYourCustomerWithID/{id}",
              defaults: new { controller = "Customer", action = "CustomerDetailsWithid", id = UrlParameter.Optional }, constraints: new {id=@"\d+" });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Customer", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
