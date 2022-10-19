using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuestPondApp.Models;
namespace QuestPondApp.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer customerobj = new Customer
            {
                CustomerCode = "1001",
                CustomerName = "Chetan Nikam"
            };
            return View("Customer",customerobj);
        }
        public ActionResult Enter()
        {
            return View("EnterCustomerNew",new Customer());/////new Customer() for the very first reuqest empty object is passed due to which empty value for input box
        }
        public ActionResult Submit(Customer datafromform)///////datafromform object will contain data if model property and form name parameter is same if not then use model binders 
        {
            //Customer obj = new Customer();
            //obj.CustomerName = Request.Form["customerName"];////////////this steps happening intenally in datafromform obj
            //obj.CustomerCode = Request.Form["customerId"];
            if(ModelState.IsValid)
            {
                return View("Customer", datafromform);
            }
            else 
            {
                return View("EnterCustomerNew",datafromform);/////if not validated it will come here and will kept previous object value in text boxes
            }
            
        }
    }
}