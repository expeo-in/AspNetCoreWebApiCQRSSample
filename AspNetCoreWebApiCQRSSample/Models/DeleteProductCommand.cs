using MediatR;

namespace AspNetCoreWebApiCQRSSample.Models
{
    public class DeleteProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
    }
}
