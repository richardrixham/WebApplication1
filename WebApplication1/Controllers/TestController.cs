using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View("MyView");
        }
    }
}