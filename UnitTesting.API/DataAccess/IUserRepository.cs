using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTesting.API.DataRepository;

namespace UnitTesting.API.DataAccess
{
    public interface IUserRepository
    {
        bool AddUser(User entity);

        IQueryable<User> GetAllUsers();
        User GetSpecificUser(int id);
    }
}
