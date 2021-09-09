using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eShopSolution.ViewModels.System.Users
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public string UserName { get; set; }

        public string Email { get; set; }

        [Display(Name = "Birthday")]
        public DateTime Dob { get; set; }

        public List<string> Roles { get; set; }
    }
}