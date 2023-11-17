using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using ProductTable.Services;
using System.Threading.Tasks;
using ProductTable.Entities;
using ProductTable.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System;
using Microsoft.AspNetCore.Hosting;

namespace ProductTable.Controllers
{
    public class ProductController : Controller
    {

        private readonly IWebHostEnvironment _hostingEnvironment;
        public ProductController(IProductService productService, IWebHostEnvironment hostingEnvironment)
        {
            _productService = productService;
            _hostingEnvironment = hostingEnvironment;
        }

       


        private readonly IProductService _productService;

        // GET: ProductControllersc
        public async Task<ActionResult> Index()
        {
            var data = await _productService.GetAllProductsAsync();
            var vm = new ProductViewModel()
            {
                Products = data
            };
            return View(vm);
        }



        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var updatedProduct = await _productService.GetProductByIdAsync(id);
            var vm = new UpdateProductViewModel
            {
                Product = updatedProduct
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UpdateProductViewModel vm, IFormFile updatedImage)
        {
            if (ModelState.IsValid)
            {
               
                await _productService.UpdateProduct(vm.Product);
                return RedirectToAction("Index");
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var vm = new AddProductViewModel
            {
                Product = new Product(),
            };
            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel vm, IFormFile addedImage)
        {
            if (ModelState.IsValid)
            {
                
            }

            return View(vm);
        }
    }
}
