using CourseProject_SoftwareArchitecture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Controllers
{

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }



    }

}
