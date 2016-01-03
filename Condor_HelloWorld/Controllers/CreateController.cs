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
            HttpCookie cook = new HttpCookie("cookiesForCreate");
            cook.Value = "email:" + createParameter.email + "#name:" + createParameter.fullName + "#password:" + createParameter.password;
            cook.Expires = DateTime.Now.AddDays(3);
            Response.Cookies.Add(cook);
            return View();
        }
        public ActionResult logIn()
        {
            CreateViewModel model = new CreateViewModel();
            if (Request.Cookies["cookiesForCreate"] != null)
            {
                string cookieValue = Request.Cookies["cookiesForCreate"].Value;
                string[] readingThatBitch = cookieValue.Split('#');
                model.email = readingThatBitch[0];
                model.fullName = readingThatBitch[1];
                model.password = readingThatBitch[2];
                model.confirmationPassword = readingThatBitch[2];
            }
            else
            {
                ViewBag.cook = "error";
            }

            return View(model);
        }


    }
}
