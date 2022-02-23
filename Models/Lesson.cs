﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Models
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public string SkillLevel { get; set; }
        public string Tuition { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
        public ICollection<Enrollment> Enrollments

        { get; set; }
    }    
}
