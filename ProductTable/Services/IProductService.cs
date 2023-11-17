using ProductTable.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductTable.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
        Task AddProduct(Product product);
        Task UpdateProduct(Product product);
        Task DeleteProduct(Product product);

        Task<Product> GetProductByIdAsync(int id);
    }
}
