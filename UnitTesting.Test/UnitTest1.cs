using System;
using Xunit;
using UnitTesting.API.Controllers;
using Moq;
using UnitTesting.API.DataRepository;
using UnitTesting.API.BuisinessLogic;
using System.Collections.Generic;

namespace UnitTesting.Test
{
    public  class UnitTest1
    {
      
        [Fact]
        public void GetSpecificUserTest()
        {
            User sampleuser = new User() { Id = 1, FirstName = "Bratin", LastName = "Kundu", Email = "bkundu53@gmail.com" };
            var moc = new Mock<IUserBL>();
            moc.Setup(mc => mc.GetSpecificUser(1)).Returns(sampleuser);
            var userobj = new UsersController(moc.Object);
            var result = userobj.GetSpecificUser(1);

            Assert.Equal(sampleuser, result);
        }


        [Fact]
        public void GetSpecificUserTest2()
        {
            User sampleuser = new User() { Id = 2, FirstName = "Bratin", LastName = "Kundu", Email = "bkundu53@gmail.com" };
            var moc = new Mock<IUserBL>();
            moc.Setup(mc => mc.GetSpecificUser(1)).Returns(sampleuser);

            var userobj = new UsersController(moc.Object);
            var result = userobj.GetSpecificUser(1);


            Assert.Equal(1, result.Id);
        }



        [Fact]
        public void GetAllUsersTest()
        {
            List<User> sampleuser = new List<User>()
            {
                new User {Id = 1, FirstName = "Bratin", LastName = "Kundu", Email = "bkundu53@gmail.com" }
            };
            var moc = new Mock<IUserBL>();
            moc.Setup(mc => mc.GetAllUsers()).Returns(sampleuser);
           
            var userobj = new UsersController(moc.Object);
            var result = userobj.GetAllUsers();

            Assert.NotNull(result);
        }


        [Fact]
        public void AddUser()
        {

            User sampleuser = new User { Id = 1, FirstName = "Bratin", LastName = "Kundu", Email = "bkundu53@gmail.com" };
            
            var moc = new Mock<IUserBL>();
            moc.Setup(mc => mc.AddUser(sampleuser)).Returns(true);

            var userobj = new UsersController(moc.Object);
            bool result = userobj.AddUser(sampleuser);


            Assert.True(result);
        }


        [Fact]
        public void AddNullUser()
        {

            User sampleuser = null;

            var moc = new Mock<IUserBL>();
            moc.Setup(mc => mc.AddUser(sampleuser)).Returns(false);

            var result2 = new UsersController(moc.Object);
            bool r = result2.AddUser(sampleuser);
            Assert.True(r);
        }

    }
}
