using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTesting.API.DataAccess;
using UnitTesting.API.DataRepository;

namespace UnitTesting.API.BuisinessLogic
{
    public class UserBL : IUserBL
    {
        private IUserRepository userRepository;

        public UserBL(IUserRepository userrepository)
        {
            userRepository = userrepository;
        }

        public List<User> GetAllUsers()
        {
            var result = new List<User>();
            result = userRepository.GetAllUsers().ToList();
            return result;
        }

        public bool AddUser(User user)
        {
            if (user != null)
            {
                bool added;
                try
                {
                    userRepository.AddUser(user);
                    added = true;
                }
                catch (Exception e)
                {
                    added = false;
                }
                return added;

            }
            else
            {
                return false;
            }
        }

        public User GetSpecificUser(int id)
        {
            var result = userRepository.GetSpecificUser(id);
            return result;
        }
    }
}
