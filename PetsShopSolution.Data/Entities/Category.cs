using PetsShopSolution.Data.Enums;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Entities
{
   public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string SeoAlias { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public int SortOrder { get; set; }
        public bool IsShownOnHome { get; set; }
        public int? ParentID { get; set; }
        public Status Status { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }

    }
}
