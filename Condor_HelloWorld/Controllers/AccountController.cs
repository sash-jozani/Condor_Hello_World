using Condor_HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Condor_HelloWorld.DataModels;

namespace Condor_HelloWorld.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            if (Request.Cookies.Get("loginCookie") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("login", new { ReturnURL = Request.Path });

            }
        }
        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {

            //bool isGood = false;
            
         
            //var myuser = (from s in db.Users 
            //             where s.username == model.username 
            //             where s.password == model.password               
            //              select s.id).First();

            //if (myuser.Count() > 0)
            //{
                
            //}


            /// Check the passed model values with DB
            Condor_DB db = new Condor_DB();

            if (db.Users.Where(x => x.username == model.username && x.password == model.password).Count() > 0)
            {
                Response.Cookies.Add(new HttpCookie("loginCookie") { Expires = DateTime.Now.AddHours(2), Name = "loginCookie", Value = db.Users.Where(x => x.username == model.username && x.password == model.password).First().id.ToString() });
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("harchi", "Username or password is wrong!");
                
                return View(model);

            }

            //foreach (var user in db.Users)
            //{
            //    if (user.username == model.username && user.password == model.password)
            //    {
            //        isGood = true;
            //    }
            //}


            //if (isGood)
            //{
            //    Response.Cookies.Add(new HttpCookie("loginCookie") { Expires = DateTime.Now.AddHours(2), Name = "loginCookie", Value = "true" });
            //    return RedirectToAction("Index");
            //}
            //else
            //{
            //    return View(model);

            //}


        }


    }
}
