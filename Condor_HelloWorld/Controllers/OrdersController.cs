using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Condor_HelloWorld.DataModels;

namespace Condor_HelloWorld.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/

        public ActionResult Index()
        {
            Condor_DB db = new Condor_DB();
            int userID = Convert.ToInt32(Request.Cookies.Get("loginCookie").Value);

            return View(db.Orders.Where(x=>x.userID == userID));
        }

    }
}
