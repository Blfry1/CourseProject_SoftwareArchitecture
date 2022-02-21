using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.Models
{
  


    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int SwimmerId { get; set; }
        public int LessionId { get; set; }
        public int SessionId { get; set; }
        public Swimmer Swimmer { get; set; }
        public Lesson Lesson { get; set; }
       
    }



    
}
