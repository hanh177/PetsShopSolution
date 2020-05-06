﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace PetsShopSolution.Data.Entities
{
    public class AppUser  : IdentityUser <Guid>
    {
       // public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public List<Cart> Carts { get; set; }
        public List<FavoriteProduct> FavoriteProducts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Post> Posts { get; set; }
        public List<Order> Orders { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
