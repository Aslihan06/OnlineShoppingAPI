using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using OnlineShoppingAPI.DataAccess.Contexts;
using OnlineShoppingAPI.DataAccess.Entities;

namespace OnlineShoppingAPI.DataAccess.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(OnlineShoppingDbContext context) : base(context) { }

        public async Task<IEnumerable<Product>> GetProductsInStock()
        {
            return await _context.Products.Where(p => p.StockQuantity > 0).ToListAsync();
        }
    }
}

