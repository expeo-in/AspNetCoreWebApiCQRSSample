﻿using AspNetCoreWebApiCQRSSample.Models;
using AspNetCoreWebApiCQRSSample.Repositories;
using MediatR;

namespace AspNetCoreWebApiCQRSSample.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, Product>
    {
        private readonly IProductRepository productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await productRepository.GetById(request.Id);
        }
    }
}
