using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assessment_1.Models;

namespace Assessment_1.Controllers
{
    public class CodeController : Controller
    {
        private northwindEntities db = new northwindEntities();

        // Action 1: Return all customers residing in Germany
        public ActionResult CustomersInGermany()
        {
            var germanCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
            return View(germanCustomers); // Pass data to View
        }

        // Action 2: Return customer details with orderId == 10248
        public ActionResult CustomerDetailsWithOrder()
        {
            var customerDetails = db.Orders
                .Where(order => order.OrderID == 10248)
                .Select(order => new
                {
                    order.Customer.CustomerID,
                    order.Customer.CompanyName,
                    order.Customer.ContactName,
                    order.Customer.Country,
                    order.OrderDate
                }).FirstOrDefault();

            return View(customerDetails); // Pass data to View
        }
    }
}