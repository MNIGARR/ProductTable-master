using Microsoft.EntityFrameworkCore;
using ProductTable.Entities;
using System.Collections.Generic;

namespace ProductTable.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(

                new Product
                {
                    Id = 1,
                    Name = "Doritos",
                    Discount = 0,
                    Price = 2.99,
                    ImagePath = "https://dtgxwmigmg3gc.cloudfront.net/imagery/assets/derivations/icon/256/256/true/eyJpZCI6ImRiNWZkOTkxZTAzOWQzMzYyZjZmODg4NjhiOGI5ZjA5Iiwic3RvcmFnZSI6InB1YmxpY19zdG9yZSJ9?signature=15eaecf856f685c86c24b4b120a73de933d93367e67b7628da6d9643c4d23223"
                },
                new Product
                {
                    Id = 2,
                    Name = "Sony Headphone (Wireless)",
                    Discount = 0,
                    Price = 430,
                    ImagePath = "https://sony.scene7.com/is/image/sonyglobalsolutions/wh-ch720_Primary_image?$categorypdpnav$&fmt=png-alpha"
                },
                new Product
                {
                    Id = 3,
                    Name = "Milka",
                    Discount = 0,
                    Price = 5.50,
                    ImagePath = "https://bazarstore.az/cdn/shop/products/30175816_8371598a-b620-491e-b310-d8da1e0a08aa.jpg?v=1693603282"
                },
                new Product
                {
                    Id = 4,
                    Name = "Coca-Cola",
                    Discount = 0,
                    Price = 2.10,
                    ImagePath = "https://camperdowncellars.com.au/cdn/shop/products/038121_clipped_rev_1_b90b4b96-59d0-45e4-9428-d79a2f000b78_1320x.png?v=1681964724"
                });
        }
    }
}

