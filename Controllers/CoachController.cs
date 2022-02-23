using CourseProject_SoftwareArchitecture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Controllers
{
    [Authorize(Roles = "Coach")]

    public class CoachController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
