using ECommerceServer.Application.Repositories;
using ECommerceServer.Domain.Entities;
using ECommerceServer.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerceServer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;
        readonly private ICustomerWriteRepository _customerWriteRepository;


        public ProductsController(IProductReadRepository productReadRepository,IProductWriteRepository productWriteRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            // var guidID  = Guid.NewGuid();
            // await _customerWriteRepository.AddAsync(new() { Id = guidID, Name = "Ahmet" });


            //await  _orderWriteRepository.AddAsync(new() { Description = "aaa", Address = "dgdgd",CustomerId = guidID });
            //await _orderWriteRepository.AddAsync(new() { Description = "bbb", Address = "dagdagda",CustomerId = guidID });
            //await _orderWriteRepository.SaveAsync();

            Order data =await _orderReadRepository.GetByIdAsync("8a8fe69e-3c6d-48e2-88a4-515a8d461b39");
            data.Address = "İstanbul";
            await _orderWriteRepository.SaveAsync();
            
        }
       

    }
}
