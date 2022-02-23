using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Controllers
{
    [Authorize(Roles = "Swimmer")]

    public class SwimmerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
