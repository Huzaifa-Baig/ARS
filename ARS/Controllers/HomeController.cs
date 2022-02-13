using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ARS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View();
        }
        public ActionResult User_Profile()
        {
            return View();
        }
        public ActionResult Contact_Us()
        {
            return View();
        }
        public ActionResult About_Us()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
        public ActionResult User_Info()
        {
            return View();
        }
        public ActionResult Avail()
        {
            return View();
        }
        public ActionResult Ticket_list()
        {
            return View();
        }
        public ActionResult Ticket_Detail()
        {
            return View();
        }
        public ActionResult Flight()
        {
            return View();
        }
        public ActionResult All_Flights()
        {
            return View();
        }
        public ActionResult Flight_Detail()
        {
            return View();
        }
        public ActionResult All_User()
        {
            return View();
        }
        public ActionResult All_Tickets()
        {
            return View();
        }
        public ActionResult Special_Offers()
        {
            return View();
        }
        public ActionResult Discounts()
        {
            return View();
        }
    }
}
