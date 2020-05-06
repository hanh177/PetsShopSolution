using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public int Heart { get; set; }
        public DateTime DateCreated { get; set; }
        public string Details { get; set; }
        public string Description { get; set; }
        public string SeoAlias { get; set; }
        public string SeoDescription { get; set; }
        public string SeoTitle { get; set; }
        public int SortOrder { get; set; }
        public int Stars { get; set; }


        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        public List<Cart> Carts { get; set; }
        public List<FavoriteProduct> FavoriteProducts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
