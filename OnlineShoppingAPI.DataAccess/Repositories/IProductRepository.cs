
using OnlineShoppingAPI.DataAccess.Entities;

namespace OnlineShoppingAPI.DataAccess.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsInStock();
    }
}
