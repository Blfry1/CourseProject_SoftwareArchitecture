using CourseProject_SoftwareArchitecture.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Controllers
{
    /* GIT HUB 2/22 11:26PM*/
    [Authorize(Roles = "Coach")]

    public class CoachController : Controller
    {
        private readonly ApplicationDbContext db;
        public CoachController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddProfile()
        {
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            Coach coach = new Coach();
            if (db.Coaches.Any(i =>i.UserId == currentUserId))
            {
                coach = db.Coaches.FirstOrDefault
                    (i => i.UserId == currentUserId);
            }
            else
            {
                coach.UserId = currentUserId;
            }
            return View(coach);
        }
        [HttpPost]
        public async Task<IActionResult> AddProfile
            (Coach coach)
        {
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            if(db.Coaches.Any
                (i=> i.UserId == currentUserId))
            {
                var coachToUpdate = db.Coaches.
                    FirstOrDefault
                    (i => i.UserId == currentUserId);
                coachToUpdate.CoachName =
                    coach.CoachName;
                coachToUpdate.PhoneNumber =
                    coach.PhoneNumber;
                db.Update(coachToUpdate);
            }
            else
            {
                db.Add(coach);
            }
            await db.SaveChangesAsync();
            return View("Index");
        }
      
    }

}
