using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface IUserRepository
    {
        void AddUser(User user);
        void UpdateUser(int userId, User user);
        void DeleteUser(int userId);
    }
}
