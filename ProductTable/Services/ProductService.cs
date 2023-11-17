using ProductTable.Entities;
using ProductTable.Repository;
using System.Collections.Generic;
using System.Linq;
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

        public async Task AddProduct(Product product)
        {
            await _productRepository.Add(product);
        }

        public async Task DeleteProduct(Product product)
        {
            await _productRepository.Delete(product);
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var products = await _productRepository.GetAllAsync();
            var result = products.FirstOrDefault(p => p.Id == id);
            return result;
        }

        public async Task UpdateProduct(Product product)
        {
            await _productRepository.Update(product);
        }
    }
}
