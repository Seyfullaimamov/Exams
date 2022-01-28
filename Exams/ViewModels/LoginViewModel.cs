
using System.ComponentModel.DataAnnotations;


namespace Exams.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name= "RememberAccount")]
        public bool RememberAccount { get; set; }
    }
}
