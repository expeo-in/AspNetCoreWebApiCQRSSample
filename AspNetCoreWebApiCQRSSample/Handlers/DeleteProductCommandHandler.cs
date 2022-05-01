using AspNetCoreWebApiCQRSSample.Models;
using AspNetCoreWebApiCQRSSample.Repositories;
using MediatR;

namespace AspNetCoreWebApiCQRSSample.Handlers
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, Product>
    {
        private readonly IProductRepository productRepository;

        public DeleteProductCommandHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            return await productRepository.Delete(request.Id);
        }
    }
}
