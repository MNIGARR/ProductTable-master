using ProductTable.Entities;
using ProductTable.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ProductTable.Services
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Task<List<Product>> GetAllByKey(string key = "")
        {
            throw new System.NotImplementedException();
        }
    }
}
