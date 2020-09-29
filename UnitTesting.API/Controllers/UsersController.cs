using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UnitTesting.API.BuisinessLogic;
using UnitTesting.API.DataRepository;

namespace UnitTesting.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserBL _userBL;

        public UsersController(IUserBL userBL)
        {
            _userBL = userBL;
            System.Diagnostics.Debug.WriteLine(_userBL);
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
           var result = _userBL.GetAllUsers();
            return result;
        }


        [HttpPost]
        public bool AddUser(User userdata)
        {
            var result = _userBL.AddUser(userdata);
            return result;
        }


        [Route("{id}")]
        [HttpGet]
        public User GetSpecificUser(int id)
        {
            var result = _userBL.GetSpecificUser(id);
            return result;
        }
    }
}