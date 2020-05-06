using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public int PostId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int SortOrder { get; set; }

        public long FileSize { get; set; }

        public Post Post { get; set; }
    }
}
