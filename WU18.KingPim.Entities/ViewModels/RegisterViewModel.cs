using System.ComponentModel.DataAnnotations;

namespace WU18.KingPim.Entities.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password confirmation does not match")]
        public string ConfirmPassword { get; set; }
    }
}