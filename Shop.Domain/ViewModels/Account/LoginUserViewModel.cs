using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Domain.ViewModels.Account
{
    public class LoginUserViewModel
    {
        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string Password { get; set; }
        [Display(Name = "RememberMe")]
        public bool RememberMe { get; set; }
    }

    public enum LoginUserResult
    {
        NotFound,
        NotActived,
        Success,
        IsBlocked
    }
}
