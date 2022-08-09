// <copyright file="UserLogic.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Negocio.UserLogic
{
    using System;
    using System.Collections.Generic;
    using Sat.Recruitment.Model.Interfaces.UsersLogic;
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Class that contains the methods for to interact with the object User.
    /// </summary>
    public class UserLogic : IUserLogic
    {
        private readonly IReadFile readFile;
        private readonly IValidateUser validateUser;
        private readonly IUserType userType;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserLogic"/> class.
        /// </summary>
        /// <param name="readFile">Abstraction for the read file.</param>
        /// <param name="validateUser">Abstraction for the validate user.</param>
        /// <param name="userType">Abstraction for the user type.</param>
        public UserLogic(IReadFile readFile, IValidateUser validateUser, IUserType userType)
        {
            this.readFile = readFile;
            this.validateUser = validateUser;
            this.userType = userType;
        }

        /// <summary>
        /// Method that add a new user to the list.
        /// </summary>
        /// <param name="newUser">User Object that contains the data of the user to add.</param>
        /// <returns>Result Object.</returns>
        public Result AddUser(User newUser)
        {
            var result = new Result();

            try
            {
                string errors = this.validateUser.ValidateErrors(newUser);

                if (!string.IsNullOrEmpty(errors))
                {
                    return new Result()
                    {
                        IsSuccess = false,
                        Errors = errors,
                    };
                }

                var listOfUsers = this.readFile.ListOfUsersFromFile();

                newUser.Email = this.NormalizeEmail(newUser.Email);

                newUser.Money = this.userType.MoneyByUserType(newUser.Money, newUser.UserType);

                if (this.validateUser.ValidateDuplicade(listOfUsers, newUser))
                {
                    result.IsSuccess = false;
                    result.Errors = "The User Already Exist";
                }
                else
                {
                    result.IsSuccess = true;
                    result.Errors = "User Created";
                }
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                result.Errors = ex.Message;
            }

            return result;
        }

        private string NormalizeEmail(string email)
        {
            var aux = email.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries);

            var atIndex = aux[0].IndexOf("+", StringComparison.Ordinal);

            aux[0] = atIndex < 0 ? aux[0].Replace(".", " ") : aux[0].Replace(".", " ").Remove(atIndex);

            email = string.Join("@", new string[] { aux[0], aux[1] });

            return email;
        }
    }
}
