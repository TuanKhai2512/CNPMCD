using BaiLam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BaiLam.Controllers
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
            return View();
        }

        /*public iactionresult gallery()
        {
            return view();
        }
        public iactionresult signin()
        {
            return view();
        }
        public iactionresult blog()
        {
            return view();
        }
        public iactionresult triblog()
        {
            return view();
        }
        public iactionresult vublog()
        {
            return view();
        }
        public iactionresult aboutus()
        {
            return view();
        }*/
        


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
