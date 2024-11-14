

using OnlineShoppingAPI.DataAccess.Repositories;

namespace OnlineShoppingAPI.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IUserRepository Users { get; }
        Task<int> CompleteAsync();
    }
}

