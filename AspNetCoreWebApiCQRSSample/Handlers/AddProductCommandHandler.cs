using AspNetCoreWebApiCQRSSample.Models;
using AspNetCoreWebApiCQRSSample.Repositories;
using MediatR;

namespace AspNetCoreWebApiCQRSSample.Handlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, Product>
    {
        private readonly IProductRepository productRepository;

        public AddProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return await productRepository.Add(new Product { Name = request.Name, Price = request.Price });
        }
    }
}
