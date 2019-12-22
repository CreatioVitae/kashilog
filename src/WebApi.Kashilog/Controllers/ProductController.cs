﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApi.Kashilog.DomainObjects.Kashi.ApiResults;
using WebApi.Kashilog.Services.Kashi;
using WebApiPack.Controllers;

namespace WebApi.Kashilog.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase {
        private ProductService ProductService { get; }

        public ProductController(ProductService productService) {
            ProductService = productService;
        }

        [HttpGet]
        public async ValueTask<ActionResult> GetProducts() {
            return this.CreateHttpGetResult(await ProductService.GetAllProductsAsync());
        }

        [HttpGet("i-async-enumerable-test")]
        public IAsyncEnumerable<ProductResult> GetProducts2() => ProductService.GetAllProductsAsyncUsingIAsyncEnumerable();

        [HttpGet("{productId:int:min(1)}")]
        public async ValueTask<ActionResult> GetProduct(int productId) {
            return this.CreateHttpGetResult(await ProductService.GetProductByIdAsync(productId));
        }
    }
}