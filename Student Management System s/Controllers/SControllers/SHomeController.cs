using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System_s.Controllers.SControllers
{
    public class SHomeController : Controller
    {
        // GET: SHome
        public ActionResult Index()
        {
            return View();
        }
    }
}