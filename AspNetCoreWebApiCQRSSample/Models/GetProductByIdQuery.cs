using MediatR;

namespace AspNetCoreWebApiCQRSSample.Models
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
