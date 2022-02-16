using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ARS.Models;

namespace ARS.Controllers
{
    public class AdminController : Controller
    {
        Context cs = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        //GET: Login
        public ActionResult login() 
        { 
            return View(); 
        }
        //POST: Login
        [HttpPost]
        public ActionResult login(AdminLogin l)
        {
            var x = cs.AdminLogin.Where(a=> a.AdminName == l.AdminName && a.AdminPassword == l.AdminPassword).ToList();
            if(x != null)
            {
                return RedirectToAction("dashboard");
            }
            else
            {
                ViewBag.message="Wrong Id or Password";
            }
            return View();
        }

        //GET: Dashboard
        public ActionResult dashboard()
        {
            return View();
        }
    }
}