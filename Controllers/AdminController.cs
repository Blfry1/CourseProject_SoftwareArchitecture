using CourseProject_SoftwareArchitecture.Models;
using CourseProject_SoftwareArchitecture.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
/* GIT HUB TEST 2/21 5:33pm*/
namespace CourseProject_SoftwareArchitecture.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
      

        public IActionResult Index()
        {

            return View();
        }
        
       
    }
}


