using Microsoft.EntityFrameworkCore;
using ProductTable.Entities;

namespace ProductTable.Data
{
    public class ProductDbContext: DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> contextOptions) : base(contextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
