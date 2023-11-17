using ProductTable.Data;
using ProductTable.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProductTable.Entities;
using Microsoft.EntityFrameworkCore;


namespace ProductTable.Repository
{
    public class EFProductRepository:IProductRepository
    {

        private readonly ProductDbContext _dbcontext;

        public EFProductRepository(ProductDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public async Task Add(Product product)
        {
            await _dbcontext.Products.AddAsync(product);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _dbcontext.Products.ToListAsync();
        }
    }
}
