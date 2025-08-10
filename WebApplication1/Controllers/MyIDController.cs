using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MyIDController : Controller
    {
        // GET: MyID
        public ActionResult DescribeMySelf()
        {
            return View();
        }
    }
}