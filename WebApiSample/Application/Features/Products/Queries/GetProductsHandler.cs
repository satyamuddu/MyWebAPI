using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyWebApi.Application.Features.Products.Dtos;
using MyWebApi.Core.Interfaces;

namespace MyWebApi.Application.Features.Products.Queries
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductDto>>
    {
        private readonly IProductRepository _ProductRepository;
        public GetProductsHandler(IProductRepository productRepository)
        {
            _ProductRepository = productRepository;
            
        }
        public async Task<IEnumerable<ProductDto>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var products =  await _ProductRepository.GetAllProductsAsync();
            var productDtos = products.Select(p => new ProductDto(
                p.Id,
                p.Name,
                p.Description,
                p.Price,
                p.CreatedAt
            ));
            return (productDtos);
        }
    }
}

