using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ekobiashara.Web.Models;

namespace Ekobiashara.Web.Controllers
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

        public IActionResult BusinessInformation()
        {
            return View();
        }

        public IActionResult DashBoard()
        {
            return View();
        }

        public IActionResult Accounting()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }
        public IActionResult Expenses()
        {
            return View();
        }
        public IActionResult InternalTransactions()
        {
            return View();
        }
        public IActionResult ProductAndServices()
        {
            return View();
        }

        public IActionResult Suppliers()
        {
            return View();
        }

        public IActionResult FeedBack()
        {
            return View();
        }

        public IActionResult Taxes()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult Surveliance()
        {
            return View();
        }

        public IActionResult Sales()
        {
            return View();
        }

        public IActionResult Purchases()
        {
            return View();
        }
        public IActionResult Inventories()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }


    }
}
