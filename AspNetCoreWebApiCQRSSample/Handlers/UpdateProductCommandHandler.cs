using AspNetCoreWebApiCQRSSample.Models;
using AspNetCoreWebApiCQRSSample.Repositories;
using MediatR;

namespace AspNetCoreWebApiCQRSSample.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
    {
        private readonly IProductRepository productRepository;

        public UpdateProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await productRepository.Update(request.Id, new Product { Id = request.Id, Price = request.Price });
        }
    }
}
