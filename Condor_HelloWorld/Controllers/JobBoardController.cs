using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Condor_HelloWorld.Models;

namespace Condor_HelloWorld.Controllers
{
    public class JobBoardController : Controller
    {
        //
        // GET: /JobBoard/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PostJob() 
        {

            PostJobViewModel model = new PostJobViewModel();
            
            return View(model);
        }
    }
}
