using ProductTable.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductTable.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAllByKey(string key = "");

    }
}
