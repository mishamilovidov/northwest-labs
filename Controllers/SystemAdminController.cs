using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NorthwestLabsPrep.Controllers
{
    public class SystemAdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Account()
        {
            return View();
        }
    }
}
