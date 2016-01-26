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
        [HttpGet]
        public ActionResult PostJob() 
        {

            PostJobViewModel model = new PostJobViewModel();
            model.salary = 650.12;
            model.id = 10;
            
            return View(model);
        }

        [HttpPost]
        public ActionResult PostJob(PostJobViewModel model) 
        {
            var hello = model.id;
            return View(model);
        }


    }
}
