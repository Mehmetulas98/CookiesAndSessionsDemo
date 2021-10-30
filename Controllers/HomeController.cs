using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CookiesAndSessionsDemo.Models;
using RestSharp;
using Microsoft.AspNetCore.Http;

namespace CookiesAndSessionsDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

         
        public IActionResult Index()
        {


            //CookieOptions cookie = new CookieOptions();

            //cookie.Expires = DateTime.Now.AddYears(10);

            //HttpContext.Response.Cookies.Append("username", "mehmet", cookie);
            //HttpContext.Session.SetString("FirstSession", "SessionInfo");

            var test = HttpContext.Session.GetString("FirstSession");
            ViewBag.veri = test;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
