using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineShoppingAPI.DataAccess.Contexts;
using OnlineShoppingAPI.DataAccess.Entities;

namespace OnlineShoppingAPI.DataAccess.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(OnlineShoppingDbContext context) : base(context) { }

        // User entity'si için özel metotlar ekleyebilirsiniz
    }
}

