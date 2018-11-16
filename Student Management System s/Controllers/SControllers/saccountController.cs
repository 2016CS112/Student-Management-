using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System_s.Controllers.SControllers
{
    public class saccountController : Controller
    {
        // GET: saccount
        public ActionResult index()
        {
            return View();
        }

        public ActionResult signup()
        {
            return View();
        }
    }
}