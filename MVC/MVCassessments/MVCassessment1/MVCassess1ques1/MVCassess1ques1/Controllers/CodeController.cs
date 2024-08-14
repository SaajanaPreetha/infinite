using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCassess1ques1.Models;

public class CodeController : Controller
{
    
    private readonly northwindEntities db = new northwindEntities();

 
    public ActionResult CustomersInGermany()
    {
        List<Customer> customerList = db.Customers
                                        .Where(c => c.Country == "Germany")
                                        .ToList();
        return View(customerList);
    }


    public ActionResult CustomerWithOrder(int orderId)
    {
       
        Customer customer = db.Orders
                              .Where(o => o.OrderId == orderId)
                              .Select(o => o.Customer)
                              .FirstOrDefault();

        return View(customer);
    }
}