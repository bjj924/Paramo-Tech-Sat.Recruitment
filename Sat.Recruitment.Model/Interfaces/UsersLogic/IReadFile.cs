// <copyright file="IReadFile.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Model.Interfaces.UsersLogic
{
    using System.Collections.Generic;
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Interface for the UserLogic when it has to read a new file.
    /// </summary>
    public interface IReadFile
    {
        /// <summary>
        /// Read a file in the solution and returns the list of users.
        /// </summary>
        /// <returns>The list of users.</returns>
        List<User> ListOfUsersFromFile();
    }
}
