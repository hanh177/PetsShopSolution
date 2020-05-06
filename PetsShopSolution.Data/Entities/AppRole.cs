
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
       // public int Id { get; set; }
        public string Description { get; set; }
    }
}
