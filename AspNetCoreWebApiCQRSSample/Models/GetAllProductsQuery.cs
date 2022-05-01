using MediatR;

namespace AspNetCoreWebApiCQRSSample.Models
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>> { }
}
