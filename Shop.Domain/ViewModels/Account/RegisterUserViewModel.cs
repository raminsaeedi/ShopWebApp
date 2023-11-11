using System.ComponentModel.DataAnnotations;

namespace Shop.Domain.ViewModels.Account
{
    public class RegisterUserViewModel
    {
        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string LastName { get; set; }
        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string Password { get; set; }
        [Display(Name = "ConfirmPassword")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        [Compare("Password", ErrorMessage ="The Passwords are not same.")]
        public string ConfirmPassword { get; set; }
    }

    public enum RegisterUserResult
    {
        MobileExists,
        Success
    }
}
