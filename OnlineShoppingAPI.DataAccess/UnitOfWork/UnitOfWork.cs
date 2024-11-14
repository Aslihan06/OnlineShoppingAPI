

using OnlineShoppingAPI.DataAccess.Contexts;
using OnlineShoppingAPI.DataAccess.Repositories;

namespace OnlineShoppingAPI.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OnlineShoppingDbContext _context;

        public UnitOfWork(OnlineShoppingDbContext context)
        {
            _context = context;
            Products = new ProductRepository(context);
            Users = new UserRepository(context);
        }

        public IProductRepository Products { get; private set; }
        public IUserRepository Users { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

