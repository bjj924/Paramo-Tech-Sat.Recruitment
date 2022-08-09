// <copyright file="IValidateUser.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Model.Interfaces.UsersLogic
{
    using System.Collections.Generic;
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Interface for the ValidateUser.
    /// </summary>
    public interface IValidateUser
    {
        /// <summary>
        /// Read a file in the solution that contains a list of users.
        /// </summary>
        /// <param name="newUser">New user passed as a object in a json.</param>
        /// <returns>The stream reader of the list of user in a file.</returns>
        string ValidateErrors(User newUser);

        /// <summary>
        /// Check if the user already exist in the list.
        /// </summary>
        /// <param name="users">List of the current users.</param>
        /// <param name="newUser">New user passed as a object in a json.</param>
        /// <returns>True or False.</returns>
        bool ValidateDuplicade(List<User> users, User newUser);
    }
}
