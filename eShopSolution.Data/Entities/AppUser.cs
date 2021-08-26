﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class AppUser: IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DoB { get; set; }

        public IList<Cart> Carts { get; set; }
        public IList<Order> Orders { get; set; }

        public IList<Transaction> Transactions { get; set; }
    }
}
