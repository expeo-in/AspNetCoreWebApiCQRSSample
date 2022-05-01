using MediatR;

namespace AspNetCoreWebApiCQRSSample.Models
{
    public class AddProductCommand : IRequest<Product>
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
