using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace PetsShopSolution.Data.Entities
{
    public class Post
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public List<Image> Images { get; set; }
        public AppUser AppUser { get; set; }

    }
}
