using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System_s.Controllers.TControllers
{
    public class taccountController : Controller
    {
        // GET: taccount
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult login()
        {
            return View();
        }

        public ActionResult signup()
        {
            return View();
        }
    }
}