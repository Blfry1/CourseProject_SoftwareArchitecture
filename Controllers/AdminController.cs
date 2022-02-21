using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Controllers
{
    public class AdminController : Controller
    {
        static readonly List<string> adminHome = new List<string>

        { "Show all roles", "Add a role", "Assign user to a role", "Show all lessons", "Add a lesson" };

        public IActionResult Index()
        {
            ViewData["Admin"] = adminHome;

            return View();
        }
    }
}
