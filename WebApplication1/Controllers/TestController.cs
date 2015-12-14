using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World is old now. It&rsquo;s time for wassup Bro;)";
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;
            ViewData["Employee"] = emp;
            return View("MyView");
        }
    }
}