using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVC.Models;

namespace MyFirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good morning" : "Good afternoon";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {

            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse) {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else {
                return View();
            }
        }
    }
}
