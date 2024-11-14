using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppingAPI.DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; } // Şifreler için Data Protection kullanılacak
        public Role Role { get; set; }
    }

    public enum Role
    {
        Admin,
        Customer
    }
}

