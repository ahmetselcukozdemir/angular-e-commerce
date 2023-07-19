using ECommerceServer.Application.Repositories;
using ECommerceServer.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;


        public ProductsController(IProductReadRepository productReadRepository,IProductWriteRepository productWriteRepository)
        {
            _productReadRepository= productReadRepository;
            _productWriteRepository= productWriteRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            // await _productWriteRepository.AddRangeAsync(new()
            // {
            //     new() { Id= Guid.NewGuid(),CreatedDate = DateTime.UtcNow,Stock = 10,Price = 100,Name="Ürün 1" },
            //     new() { Id= Guid.NewGuid(),CreatedDate = DateTime.UtcNow,Stock = 20,Price = 200,Name="Ürün 2" },
            //     new() { Id= Guid.NewGuid(),CreatedDate = DateTime.UtcNow,Stock = 30,Price = 300 ,Name="Ürün 3"},
            // });

            //var count = await _productWriteRepository.SaveAsync();

           Product p = await _productReadRepository.GetByIdAsync("7e57cdfd-238c-406b-84b9-d62fd589a61f",false);
            p.Name = "Selçuk";
            _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
          Product product = await _productReadRepository.GetByIdAsync(id);
          return Ok(product);
        }

    }
}
