using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        // INDEX ROUTE
        [HttpGet("")] // <-- do this for all your routes below
        public IActionResult Index()
        {
            return View();
        }

        // PROCESS NEW QUOTE ROUTE
        public IActionResult CreateQuote()
        {
            return View();
        }

        // SHOW ALL QUOTES ROUTE
        public IActionResult Quotes()
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
