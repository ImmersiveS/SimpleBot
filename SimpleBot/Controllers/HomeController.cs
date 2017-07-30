using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBot.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "This is my telegram bot";
        }
    }
}