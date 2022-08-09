// <copyright file="UserControllerTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Test
{
    using Moq;
    using Sat.Recruitment.Api.Controllers;
    using Sat.Recruitment.Model.Interfaces.UsersLogic;
    using Sat.Recruitment.Model.Models;
    using Xunit;

    /// <summary>
    /// Test for the Controller "UserController".
    /// </summary>
    [CollectionDefinition("Tests", DisableParallelization = true)]
    public class UserControllerTest
    {
        private readonly Mock<IUserLogic> mockUserLogic = new Mock<IUserLogic>();

        /// <summary>
        /// Test that will pass if the user is correctly created.
        /// </summary>
        [Fact]
        public void CreateUserOK()
        {
            this.mockUserLogic.Setup(x => x.AddUser(It.IsAny<User>()))
                .Returns(new Result
                {
                    IsSuccess = true,
                    Errors = "User Created",
                });

            var userController = new UsersController(this.mockUserLogic.Object);

            var result = userController.CreateUser(this.NewUserOK());

            Assert.Equal(true, result.IsSuccess);
            Assert.Equal("User Created", result.Errors);
        }

        /// <summary>
        /// Test that will return that the user is already in the list.
        /// </summary>
        [Fact]
        public void CreateUserExistFail()
        {
            this.mockUserLogic.Setup(x => x.AddUser(It.IsAny<User>()))
                .Returns(new Result
                {
                    IsSuccess = false,
                    Errors = "The user is duplicated",
                });

            var userController = new UsersController(this.mockUserLogic.Object);

            var result = userController.CreateUser(this.DuplicateUser());

            Assert.Equal(false, result.IsSuccess);
            Assert.Equal("The user is duplicated", result.Errors);
        }

        private User NewUserOK()
        {
            return new User
            {
                Name = "Mike",
                Address = "Av. Juan G",
                Email = "mike@gmail.com",
                Money = 124,
                Phone = "+349 1122354215",
                UserType = "Normal",
            };
        }

        private User DuplicateUser()
        {
            return new User
            {
                Name = "Agustina",
                Address = "Av. Juan G",
                Email = "Agustina@gmail.com",
                Money = 124,
                Phone = "+349 1122354215",
                UserType = "Normal",
            };
        }
    }
}
