using CourseProject_SoftwareArchitecture.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject_SoftwareArchitecture.ViewModels
{
    
    public class AdminAddUserRoleViewModel
    {
        public ApplicationUser User { get; set; }
        public string Role { get; set; }
        public SelectList RoleList { get; set; }
    }
}
