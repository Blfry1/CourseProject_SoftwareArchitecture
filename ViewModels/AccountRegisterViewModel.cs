using System.ComponentModel.DataAnnotations;

namespace CourseProject_SoftwareArchitecture.ViewModels
{
    public class AccountRegisterViewModel
    {
        [Required, MaxLength(256), EmailAddress]
        [Display(Name ="Email Address")]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
        [Required, MinLength(6), MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Password does not match, try again")]
        public string ConfirmPassword { get; set; }
    }
}
