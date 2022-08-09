// <copyright file="IUserLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Model.Interfaces.UsersLogic
{
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Interface for the UserLogic methods in the business layer.
    /// </summary>
    public interface IUserLogic
    {
        /// <summary>
        /// Method to add a new User to the list.
        /// </summary>
        /// <param name="newUser">New user passed as a object in a json.</param>
        /// <returns>new Result object.</returns>
        Result AddUser(User newUser);
    }
}
