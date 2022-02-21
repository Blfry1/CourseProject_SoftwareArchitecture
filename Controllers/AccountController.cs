using CourseProject_SoftwareArchitecture.Models;
using CourseProject_SoftwareArchitecture.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* GITHUB TEST 2/21 5:50PM */

namespace CourseProject_SoftwareArchitecture.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationDbContext db;
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;
        private RoleManager<IdentityRole> roleManager;
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            this.db = db;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AccountRegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user= new ApplicationUser { UserName = vm.Email,
                Email = vm.Email };
                var result = await userManager.CreateAsync(user, vm.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }
        public IActionResult Login ()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(AccountLoginViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync
                    (vm.Email, vm.Password, false, false);
                if (result.Succeeded)
                {
                    var user = await userManager.FindByEmailAsync(vm.Email);
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles.Contains("Admin"))
                    {
                        return RedirectToAction("Index", "Admin");
                    }
                    else if (roles.Contains("Swimmer"))
                    {
                        return RedirectToAction("Index", "Swimmer");
                    }
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("", "Login Failure.");
            }
            return View(vm);
        }
        public IActionResult AllUser()
        {
            var users = db.Users.ToList();
            return View(users);
        }

    }       
}
