using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System_s.Controllers
{
    public class TAttancedenceController : Controller
    {
        // GET: TAttancedence
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult StudentAttandence()
        {
            return View();
        }
    }
}