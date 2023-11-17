using ProductTable.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductTable.Repository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();

        Task Add(Product product);
    }
}

