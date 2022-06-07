using MVCRoutingConceptDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRoutingConceptDemo.Controllers
{
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
        public ActionResult Index()
        {
            var CustomerList = customers.ToList();
            return View(CustomerList);
        }

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

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
