using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condor_HelloWorld.Controllers
{
    public class WebDevController : Controller
    {
        //
        // GET: /WebDev/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CookieStyle(int id)
        {

            // Request
            // Response   

            HttpCookie cook = new HttpCookie("Coce");

             cook.Value = "This is my cookie: " + id.ToString();
            cook.Expires = DateTime.Now.AddDays(11);

            Response.Cookies.Add(cook);

            return View();
        }


        public ActionResult ReadCookie()
        {
            //string cook =
            if (Request.Cookies["Coce"] != null)
            {
                ViewBag.cook = Request.Cookies["Coce"].Value;
            }
            else
            {
                ViewBag.cook = "No Cookie Found";
            }


            return View();
        }

        public ActionResult QueryStyle(int id)
        {
            
            //NameValueCollection qs = Request.QueryString;
            //qs.GetKey(0).Where(x=>x.ToString() == "Item1").Select(m=>m.ToString());

            string key = "123123keykeykir";


            ViewBag.Item1 = Request["firstName"];
            ViewBag.Item2 = Request["lastName"];
            ViewBag.Item3 = Request["country"];



            ViewBag.meID = id;
            return View();
        }


        public ActionResult SessionStyle(int id)
        {

            Session["esm"] = id;

            ViewBag.Item1 = Session["esm"];
            


            ViewBag.meID = id;
            return View();
        }


    }
}
