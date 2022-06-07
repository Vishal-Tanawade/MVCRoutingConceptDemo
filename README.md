# MVCRoutingConceptDemo
## Asp .Net Web Application (.Net Framework)
- Date: 05-May-2022

## Routing Types:
1) Conventional Routing
2) Attribute Routing 

## 1. Conventional Routing 
- we required to enter url as it 
### RouteConfig.cs
- Always add MapRoute before default.
- Don't Remove default route.
                
```
routes.MapRoute(
                name: "CustomerList",  //Name should be unique for each route
                url:"CustomerPortal",  
                defaults: new{controller="Customer",action="Index" });
```
- Enter this url after run: <b>http://localhost:55203/CustomerPortal/Register</b>
```
 routes.MapRoute(
                name: "CustomerAdd",  //Name should be unique for each route
                url: "CustomerPortal/Register",
                defaults: new { controller = "Customer", action = "AddCustomer" });
```
##  1. Attribute Routing 
- Add below line in RouteConfig.cs
```
 routes.MapMvcAttributeRoutes(); //This line added to enable attribute routing
    
```
- And add below thow line in Controller
```
 [RoutePrefix("MyController")]
    public class CustomerController : Controller
    {
        [Route("MyCustomer")]
        public ActionResult Index()
        {
            var CustomerList = customers.ToList();
            return View(CustomerList);
        }
```
- Enter this url => http://localhost:55203/MyController/MyCustomer
- Default url will not work 
 
