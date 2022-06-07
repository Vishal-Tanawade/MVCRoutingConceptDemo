using MVCRoutingConceptDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoutingConceptDemo.Controllers
{
    [RoutePrefix("MyController")]
    public class CustomerController : Controller
    {
        static List<ClsCustomer> customers = new List<ClsCustomer>()
        {
            new ClsCustomer()
            {
                CustCode=1001,
                CustName="Vishal",
                CustDOJ=new DateTime(2020,12,12)
            },

            new ClsCustomer()
            {
                CustCode=1002,
                CustName="Mahesh",
                CustDOJ=new DateTime(2021,12,12)
            },
            new ClsCustomer()
            {
                CustCode=null,
                CustName="Sagar",
                CustDOJ=null
            }

        };


        // GET: Customer
        [Route("MyCustomer")]
        public ActionResult Index()
        {
            var CustomerList = customers.ToList();
            return View(CustomerList);
        }


        //http://localhost:55203/Customer/AddCustomer 
        // goto manually this url 
        [HttpGet]
        public ActionResult AddCustomer()
        {

            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(ClsCustomer clsCustomer)
        {
            customers.Add(clsCustomer);
          //  return RedirectToAction("CustomerDetails", clsCustomer);
            return View("CustomerDetails",clsCustomer);
        }


        [HttpGet]
        public ActionResult CustomerDetails(ClsCustomer clsCustomer)
        {
            ClsCustomer cust = customers.FirstOrDefault(x => x.CustCode == clsCustomer.CustCode);
            return View(cust);
        }

      [HttpGet]
        //http://localhost:55203/Customer/CustomerDetailsWithid/{id}
        // goto this url manually
        public ActionResult CustomerDetailsWithid(int? id)
        {
            ClsCustomer cust = customers.FirstOrDefault(x => x.CustCode == id);
            return View(cust);
        }

        [HttpGet]
        public ActionResult CustomerDetailsWithRegularExpression(string custid)
        {
            int id = 1001;

            ClsCustomer cust = customers.FirstOrDefault(x => x.CustCode == id);
            return View(cust);
        }

      
    }
}
