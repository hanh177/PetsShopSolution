using PetsShopSolution.Data.Entities;
using PetsShopSolution.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of eShopSolution" },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
               );
            

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    ID = 1,
                    Name ="Chó",
                    SeoAlias="cho",
                    SeoDescription="Hãy lựa chọn những chú cún bạn yêu thích",
                    SeoTitle= "Những chú cún con đáng yêu nhất đang chờ bạn đón về nhà",
                    IsShownOnHome = true,
                    ParentID = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                 new Category()
                 {
                     ID = 2,
                     Name = "Mèo",
                     SeoAlias = "Meo",
                     SeoDescription = "Hãy lựa chọn những chú mèo bạn yêu thích",
                     SeoTitle = "Quàng thượng đang chờ sen rinh về :P",
                     IsShownOnHome = true,
                     ParentID = null,
                     SortOrder = 2,
                     Status = Status.Active,
                 } );


            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               ID = 1,
               Name= "Chó Husky lông đen 3 tháng tuổi",
               SeoAlias= "Cho-Husky-long-den-3-thang-tuoi",
               SeoTitle= "Chó Husky lông đen 3 tháng tuổi",
               SeoDescription= "Chó Husky lông đen 3 tháng tuổi",
               Details= "Chó Husky lông đen 3 tháng tuổi",
               Description= "Chó Husky lông đen 3 tháng tuổi",
               Heart = 0,
               Stars=0,
               DateCreated = DateTime.Now,
               OriginalPrice = 3200000,
               Price = 6000000,
               Stock = 0,
               ViewCount = 0,
           },
            new Product()
            {
                ID = 2,
                Name = "Mèo Ai Cập lông trắng mắt xanh",
                SeoAlias = "meo-ai-cap-long-trang-mat-xanh",
                SeoTitle = "Mèo Ai Cập lông trắng mắt xanh",
                SeoDescription = "Mèo Ai Cập lông trắng mắt xanh",
                Details = "Mèo Ai Cập lông trắng mắt xanh",
                Description = "Mèo Ai Cập lông trắng mắt xanh",
                Heart=0,
                Stars=0,
                DateCreated = DateTime.Now,
                OriginalPrice = 1500000,
                Price = 2300000,
                Stock = 0,
                ViewCount = 0,
            });

            modelBuilder.Entity<ProductInCategory>().HasData(
               new ProductInCategory() { ProductId = 1, CategoryId = 1 },
                new ProductInCategory() { ProductId = 2, CategoryId = 2 }
               );


            // any guid
            //var roleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            //var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            //modelBuilder.Entity<AppRole>().HasData(new AppRole
            //{
            //    Id = roleId,
            //    Name = "admin",
            //    NormalizedName = "admin",
            //    Description = "Administrator role"
            //});

            //var hasher = new PasswordHasher<AppUser>();
            //modelBuilder.Entity<AppUser>().HasData(new AppUser
            //{
            //    Id = adminId,
            //    UserName = "admin",
            //    NormalizedUserName = "admin",
            //    Email = "haanh0611@gmail.com",
            //    NormalizedEmail = "haanh0611@gmail.com",
            //    EmailConfirmed = true,
            //    PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
            //    SecurityStamp = string.Empty,
            //    FirstName = "Anh",
            //    LastName = "Ha",
            //    Dob = new DateTime(1999, 07, 17)
            //});

            //modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            //{
            //    RoleId = roleId,
            //    UserId = adminId
            //});
        }



    }
}
