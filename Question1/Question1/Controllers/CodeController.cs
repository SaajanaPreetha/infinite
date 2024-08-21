using Question1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Question1.Controllers
{
    public class CodeController : Controller
    {
        northwindEntities nw = new northwindEntities();
        // GET: Code
        public ActionResult Index()
        {
            return View(nw.Customers.ToList());
        }
        public ActionResult In_Germany()
        {
            List<string> li = (from g in nw.Customers
                               where g.Country == "Germany"
                               select g.CustomerID).ToList();
            return View(li);
        }
        public ActionResult CustomersByOrderId(int orderId = 10248)
        {
            var cust = nw.Customers.Where(c => c.Orders.Any(o => o.OrderID == orderId));
            if (cust == null)
            {
                return HttpNotFound();
            }
            return View(cust);
        }
    }
}
    