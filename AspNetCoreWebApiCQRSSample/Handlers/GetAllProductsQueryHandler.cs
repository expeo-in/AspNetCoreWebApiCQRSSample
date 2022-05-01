using AspNetCoreWebApiCQRSSample.Models;
using AspNetCoreWebApiCQRSSample.Repositories;
using MediatR;

namespace AspNetCoreWebApiCQRSSample.Handlers
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
    {
        private readonly IProductRepository productRepository;

        public GetAllProductsQueryHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetAll();
        }
    }
}
