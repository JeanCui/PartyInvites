﻿using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.myGreeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
            //return "Hello World";
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            { 
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }


            
        }

    }
}