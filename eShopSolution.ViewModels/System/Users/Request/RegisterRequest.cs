using System;
using System.ComponentModel.DataAnnotations;

namespace eShopSolution.ViewModels.System.Users.Request
{
    public class RegisterRequest
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Birth Day")]
        [DataType(DataType.Date)]
        public DateTime DoB { get; set; }

        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}