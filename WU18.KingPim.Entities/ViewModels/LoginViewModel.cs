using System.ComponentModel.DataAnnotations;

namespace WU18.KingPim.Entities.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}