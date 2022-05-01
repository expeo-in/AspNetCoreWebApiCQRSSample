using MediatR;

namespace AspNetCoreWebApiCQRSSample.Models
{
    public class UpdateProductCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
    }
}
