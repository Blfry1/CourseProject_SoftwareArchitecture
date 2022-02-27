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
    /*GIT HUB 2/23 8:10PM */
    /* GIT HUB 2/22 11:26PM JB*/
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
            if (db.Coaches.Any(i => i.UserId == currentUserId))
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
            if (db.Coaches.Any
                (i => i.UserId == currentUserId))
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
        public IActionResult AddSession()   
        {
            Session session = new Session();
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            session.CoachId = db.Coaches.SingleOrDefault(i => i.UserId == currentUserId).CoachId;  //If you get an error, Coach needs to add a profile first
            return View(session);
        }
        [HttpPost]
        public async Task<IActionResult> AddSession(Session session)
        {
            db.Add(session);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Coach");
        }
        public async Task<IActionResult> SessionByCoach()
        {
            var currentUserId = this.User.FindFirst
                (ClaimTypes.NameIdentifier).Value;
            var CoachId = db.Coaches.SingleOrDefault
                (i => i.UserId == currentUserId).CoachId;
            var session = await db.Sessions.Where(i =>
            i.CoachId == CoachId).ToListAsync();
            return View(session);
        }

        public async Task <IActionResult> AddProgressReport(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var allSwimmers = await db.Enrollments.Include
                (c => c.Session).Where(c => c.SessionId == id)
                .ToListAsync();
            if (allSwimmers == null)
            {
                return NotFound();
            }
            return View(allSwimmers);
        }

        [HttpPost]
        public IActionResult AddProgressReport(List<Enrollment> enrollments)
        {
            foreach (var enrollement in enrollments)
            {
                var er = db.Enrollments.Find(enrollement.EnrollmentId);
                er.ProgressReport = enrollement.ProgressReport;
            }

            db.SaveChanges();
            return RedirectToAction("SessionByCoach");
        }


        public IActionResult AllLesson()
        {
            var lessons = db.Lessons.ToList();
            return View(lessons);
        }

        

    }
}

