using Condor_HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Condor_HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Condors() 
        {
            return View();
        }

        public ActionResult Condor(int id, string username)
        {
            id = id * 2;
            CondorViewModel hasan = new CondorViewModel();

            hasan.id = id;
            hasan.username = username;

            //ViewBag.Hamed = id;

            return View(hasan);
        }

        public ActionResult Movie(MovieViewModel model) 
        {

            
            return View(model);
        }

    }
}
