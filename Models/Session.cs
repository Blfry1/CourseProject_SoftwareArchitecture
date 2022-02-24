﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public string StartDate{ get; set; }
        public string EndDate { get; set; }
        public int SeatCapacity { get; set; }
        public string DailyStartTime { get; set; }
        public int CoachId { get; set; }
        public Coach Coach { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }

    }
}
