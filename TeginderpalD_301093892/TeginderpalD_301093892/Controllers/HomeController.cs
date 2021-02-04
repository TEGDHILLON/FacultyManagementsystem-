using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TeginderpalD_301093892.Models;

namespace TeginderpalD_301093892.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult AddFaculty()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddFaculty(Faculty faculty)
        {
            if (ModelState.IsValid)
            {
                Repository.AddFaculty(faculty);
                return View("FacultyAddition",faculty);
            }
            else
            {
                return View();
            }
        }   

        public ViewResult ViewFaculty()
        {
            return View(Repository.Addition);
        }

        [HttpGet]
        public ViewResult AddCourse()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddCourse(Course course)
        {
            if (ModelState.IsValid)
            {
                Repository.AddCourse(course);

                return View("CourseEnrolled", course);
            }
            else
            {
                return View();
            }
        }

        public ViewResult ViewCourse()
        {
            return View(Repository.Enrolled);
        }

        public ViewResult Contact()
        {
            return View();
        }

    }
}
