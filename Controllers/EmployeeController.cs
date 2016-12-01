using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NorthwestLabsPrep.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
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

        public IActionResult TestSchedule()
        {
            return View();
        }

        public IActionResult CompoundReceipt()
        {
            return View();
        }

        public IActionResult UploadTestResults()
        {
            return View();
        }

        public IActionResult Assays()
        {
            return View();
        }

        public IActionResult AssayCatalog()
        {
            return View();
        }

        public IActionResult UpdateAssayCatalogInfo()
        {
            return View();
        }

        public IActionResult Reports()
        {
            return View();
        }
    }
}
