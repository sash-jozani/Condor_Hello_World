using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Condor_HelloWorld.Models;


namespace Condor_HelloWorld.Controllers
{
    public class QSController : Controller
    {
        //
        // GET: /QS/

        public ActionResult Index()
        {
            QSViewModel model = new QSViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult searching(QSViewModel model)
        {
            return View();

            //return RedirectToAction("searching", new { search = model.shitYouSearched });
        }
        public ActionResult searching()
        {

            return View();
        }
    }
}
