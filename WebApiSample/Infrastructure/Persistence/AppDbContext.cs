using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyWebApi.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        private readonly List<Core.Entities.Product> _products = new();
        public AppDbContext()
        {
            // Seed with some dummy data
            _products.Add(new Core.Entities.Product
            {
                Id = 1,
                Name = "Sample Product 1",
                Description = "Description for product 1",
                Price = 10.99m,
                CreatedAt = DateTime.UtcNow
            });
            _products.Add(new Core.Entities.Product
            {
                Id = 2,
                Name = "Sample Product 2",
                Description = "Description for product 2",
                Price = 20.99m,
                CreatedAt = DateTime.UtcNow
            });
        }
        public Task<List<Core.Entities.Product>> GetProductsAsync()
        {
            return Task.FromResult(_products);
        }
    }
}