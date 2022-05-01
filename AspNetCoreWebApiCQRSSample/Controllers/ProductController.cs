using AspNetCoreWebApiCQRSSample.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreWebApiCQRSSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await mediator.Send(new GetAllProductsQuery());
        }

        [HttpGet("{id}")]
        public async Task<Product> GetById(int id)
        {
            return await mediator.Send(new GetProductByIdQuery { Id = id });
        }

        [HttpPost]
        public async Task<Product> Add(AddProductCommand product)
        {
            return await mediator.Send(product);
        }

        [HttpPut("{id}")]
        public async Task<Product> Update(int id, UpdateProductCommand product)
        {
            return await mediator.Send(product);
        }

        [HttpDelete("{id}")]
        public async Task<Product> Delete(int id)
        {
            return await mediator.Send(new DeleteProductCommand { Id = id });
        }
    }
}
