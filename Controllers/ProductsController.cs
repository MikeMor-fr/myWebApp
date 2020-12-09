using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using myWebApp.Models;
using myWebApp.Services;

namespace myWebApp.Controllers
{
    [Route("/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}