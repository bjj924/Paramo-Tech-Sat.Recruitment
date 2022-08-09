// <copyright file="IUserType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Model.Interfaces.UsersLogic
{
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Interface for the UserLogic methods in the business layer.
    /// </summary>
    public interface IUserType
    {
        /// <summary>
        /// Method that return the plus in the money by type of user.
        /// </summary>
        /// <param name="money">Decimal value with the current user money.</param>
        /// <param name="userType">String value with the type user.</param>
        /// <returns>new Result object.</returns>
        decimal MoneyByUserType(decimal money, string userType);
    }
}
