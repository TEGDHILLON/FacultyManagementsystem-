using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TeginderpalD_301093892.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ViewResult AddFaculty()
        {
            return View();
        }

        public ViewResult Faculty()
        {
            return View();
        }

        public ViewResult AddCourse()
        {
            return View();
        }

        public ViewResult Course()
        {
            return View();
        }
    }
}