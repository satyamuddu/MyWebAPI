using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebApi.Application.Features.Products.Dtos
{
    public record ProductDto(
        int Id,
        string Name,
        string Description,
        decimal Price,
        DateTime CreatedAt
    );
    
        
    
}