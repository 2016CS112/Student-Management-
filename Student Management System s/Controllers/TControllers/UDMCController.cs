using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student_Management_System_s.Controllers.TControllers
{
    public class UDMCController : Controller
    {
        // GET: UDMC
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UploadGrade()
        {
            return View();
        }
    }
}