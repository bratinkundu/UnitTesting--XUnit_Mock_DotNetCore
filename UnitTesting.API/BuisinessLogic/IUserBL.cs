using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTesting.API.DataRepository;

namespace UnitTesting.API.BuisinessLogic
{
    public interface IUserBL
    {
         List<User> GetAllUsers();
         bool AddUser(User user);
        User GetSpecificUser(int id);
    }
}
