// <copyright file="UsersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Sat.Recruitment.Model.Interfaces.UsersLogic;
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Controller for the User Endpoints.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public partial class UsersController : ControllerBase
    {
        private readonly IUserLogic userLogic;

        /// <summary>
        /// Initializes a new instance of the <see cref="UsersController"/> class.
        /// </summary>
        /// <param name="userLogic">Interface that contains the methods for the business layer.</param>
        public UsersController(IUserLogic userLogic)
        {
            this.userLogic = userLogic;
        }

        /// <summary>
        /// Endpoint to Create a new User from a json.
        /// </summary>
        /// <param name="newUser">Json that contains the attributes of the new User.</param>
        /// <returns>Return a Result object with the response, status code and a error message if it's corresponds.</returns>
        [HttpPost]
        [Route("/newUser")]
        public Result CreateUser([FromBody] User newUser)
        {
            var createUser = this.userLogic.AddUser(newUser);

            return createUser;
        }
    }
}
