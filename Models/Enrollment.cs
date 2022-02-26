using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Models
{
    public enum Grade
    {
        A, B, C, D, F, I, W, P
    }


    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int SwimmerId { get; set; }
        public int SessionId { get; set; }
        public Swimmer Swimmer { get; set; }
        public Session Session { get; set; }

        private LetterGrade letterGrade;

        public LetterGrade GetLetterGrade()
        {
            return letterGrade;
        }

        public void SetLetterGrade(LetterGrade value)
        {
            letterGrade = value;
        }
    }
}


      