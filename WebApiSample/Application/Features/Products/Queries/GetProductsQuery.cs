using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MyWebApi.Application.Features.Products.Dtos;

namespace MyWebApi.Application.Features.Products.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<ProductDto>>;
}