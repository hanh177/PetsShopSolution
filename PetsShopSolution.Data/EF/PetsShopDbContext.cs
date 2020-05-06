using eShopSoluPetsShopSolutiontion.Data.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PetsShopSolution.Data.Configurations;
using PetsShopSolution.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetsShopSolution.Data.EF
{
    public class PetsShopDbContext : DbContext
    {
        public PetsShopDbContext(DbContextOptions options) : base(options)
        {
        }

        //Khai bao Entities
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductsImages { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }
        public DbSet<FavoriteProduct> FavoriteProducts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //configuration by Fluent API
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new CommentConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            modelBuilder.ApplyConfiguration(new FavoriteProductConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new ImageConfiguration());


            //modelBuilder.Entity<Microsoft.AspNet.Identity.EntityFramework.IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            //modelBuilder.Entity<Microsoft.AspNet.Identity.EntityFramework.IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            //modelBuilder.Entity<Microsoft.AspNet.Identity.EntityFramework.IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            //modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            //modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            //Data seeding
            //modelBuilder.Seed();
            //;base.OnModelCreating(modelBuilder);
        }
    }
}
