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

        public async Task Delete(Product product)
        {
            var DeleteProduct = await _dbcontext.Products.FindAsync(product.Id);
            _dbcontext.Remove(DeleteProduct);
            await _dbcontext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _dbcontext.Products.ToListAsync();
        }


       

        public async Task Update(Product product)
        {
            var UpdateProduct = await _dbcontext.Products.FindAsync(product.Id);
            if (UpdateProduct != null)
            {
                UpdateProduct.Name = product.Name;
                UpdateProduct.Price = product.Price;
                UpdateProduct.Discount = product.Discount;
                UpdateProduct.ImagePath = product.ImagePath;
                _dbcontext.Update(UpdateProduct);
                await _dbcontext.SaveChangesAsync();
            }
            
        }
    }
}
