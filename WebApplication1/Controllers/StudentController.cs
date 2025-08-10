using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello and  " + name;
            // This is my first change for the GitHub assignment.
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}