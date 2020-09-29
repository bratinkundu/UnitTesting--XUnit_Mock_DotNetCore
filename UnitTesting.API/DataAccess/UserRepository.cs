using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitTesting.API.DataRepository;

namespace UnitTesting.API.DataAccess
{
    public class UserRepository : IUserRepository
    {
        private UserDbContext userDbContext;
        private DbSet<User> dbSet;

        public UserRepository(UserDbContext dbContext)
        {
            userDbContext = dbContext;
            dbSet = userDbContext.Set<User>();
        }

        public bool AddUser(User user)
        {
            try
            {
                dbSet.Add(user);
                userDbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
                
        }

        public virtual IQueryable<User> GetAllUsers()
        {
            return dbSet;
        }

        public User GetSpecificUser(int id)
        {
            User result = dbSet.Find(id);
            return result;
        }

       
    }
}
