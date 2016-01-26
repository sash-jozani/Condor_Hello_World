using Condor_HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Condor_HelloWorld.Controllers
{
    public class CreateController : Controller
    {
        //
        // GET: /Create/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            CreateViewModel model = new CreateViewModel();
            return View(model);

        }

        [HttpPost]
        public ActionResult Create(CreateViewModel createParameter)
        {
        //    int counter = 0;
        //    var cnt = Request.Cookies["counter"] == null ? string.Empty : Request.Cookies["counter"].Value;

        //    if (!string.IsNullOrEmpty(cnt))
        //    {
        //        counter =  Convert.ToInt32(cnt);
        //        HttpCookie cookie = new HttpCookie("counter");
        //        cookie.Value = (counter + 1).ToString();
        //        cookie.Expires = DateTime.Now.AddDays(3);
        //        Response.Cookies.Add(cookie);
        //    }
        //    else
        //    {
        //        HttpCookie cookie = new HttpCookie("counter");
        //        cookie.Value = "0";
        //        cookie.Expires = DateTime.Now.AddDays(3);
        //        Response.Cookies.Add(cookie);
        //    }

            HttpCookie cook = new HttpCookie("cookiesForCreate");
            cook.Value = "email:" + createParameter.email + "#name:" + createParameter.fullName + "#password:" + createParameter.password;
            cook.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cook);
            return RedirectToAction("index");
        }

        public ActionResult logIn()
        {
            CreateViewModel model = new CreateViewModel();
            if (Request.Cookies["cookiesForCreate"] != null)
            {
                //string cookieValue = Request.Cookies["cookiesForCreate"].Value;
                //string[] readingThatBitch = cookieValue.Split('#');
                //model.email = readingThatBitch[0].Replace("email:","");
                //model.fullName = readingThatBitch[1];
                //model.password = readingThatBitch[2];
                //model.confirmationPassword = readingThatBitch[2];
            }
            else
            {
                ViewBag.cook = "error";
            }
            //return RedirectToAction("Index", "Create");
            return View(model);
        }
        [HttpPost]
        public ActionResult logIn(CreateViewModel loginParameter) 
        {

            string enteredEmail = loginParameter.email;
            string enteredPass = loginParameter.password;
            string cookieValue = Request.Cookies["cookiesForCreate"].Value;
            string[] readingThatBitch = cookieValue.Split('#');
            string orginalEmail = readingThatBitch[0].Replace("email:", "");
            string orginalPassword = readingThatBitch[2].Replace("password:", "");

            if (enteredEmail == orginalEmail && enteredPass==orginalPassword)
            {
                return RedirectToAction("sucess");
            }
            else
            {
                CreateViewModel model = new CreateViewModel();
                ViewBag.wrong = "true";
                return View(model);
            }
        }

        public ActionResult sucess()
        {
            return View();
        }

    }
}
