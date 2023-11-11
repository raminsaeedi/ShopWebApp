using Shop.Domain.Models.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Shop.Domain.Models.Account
{
    public class User : BaseEntity
    {
        [Display(Name = "FirstName")]
        [Required(ErrorMessage ="Please insert the {}.")]
        [MaxLength(200, ErrorMessage="The {0} can't be longer than {1} Characters.")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string LastName { get; set; }
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string UserName { get; set; }
        [Display(Name = "PhoneNumber")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string Password { get; set; }
        [Display(Name = "Avatar")]
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string Avatar { get; set; }
        [Display(Name = "Blocked")]
        public bool IsBlocked { get; set; }
        [Required(ErrorMessage = "Please insert the {}.")]
        [MaxLength(200, ErrorMessage = "The {0} can't be longer than {1} Characters.")]
        public string MobileActiveCode { get; set; }
        [Display(Name = "Is Active?")]
        public bool IsMobileActived { get; set; }
        [Display(Name ="Gender")]
        public UserGender UserGender { get; set; }
    }

    public enum UserGender
    {
        [Display(Name = "Femail")]
        Femail,
        [Display(Name = "Male")]
        Male,
        [Display(Name = "Deverse")]
        Deverse,
        [Display(Name = "Unknown")]
        Unknown
    }
}
