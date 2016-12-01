using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NorthwestLabsPrep.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Employees()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult SubmitOrder()
        {
            return View();
        }

        public IActionResult OrderStatus()
        {
            return View();
        }

        public IActionResult Assays()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }

        public IActionResult GenerateSalesReport()
        {
            return View();
        }

        public IActionResult GenerateClientReport()
        {
            return View();
        }
    }
}
