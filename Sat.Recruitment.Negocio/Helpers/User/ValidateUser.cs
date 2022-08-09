// <copyright file="ValidateUser.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Negocio.Helpers.User
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using Sat.Recruitment.Model.Interfaces.UsersLogic;
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Class to validate error in the object or if the user already exist.
    /// </summary>
    public class ValidateUser : IValidateUser
    {
        /// <summary>
        /// Validate if one of the attributes in the object is null or empty.
        /// </summary>
        /// <param name="newUser">Object that contains the data of the user.</param>
        /// <returns>Return a string with the error.</returns>
        public string ValidateErrors(User newUser)
        {
            string errors = string.Empty;

            if (newUser.Name == null)
            {
                // Validate if Name is null
                errors = "The name is required";
            }

            if (newUser.Email == null)
            {
                // Validate if Email is null
                errors = errors + " The email is required";
            }

            if (newUser.Address == null)
            {
                // Validate if Address is null
                errors = errors + " The address is required";
            }

            if (newUser.Phone == null)
            {
                // Validate if Phone is null
                errors = errors + " The phone is required";
            }

            return errors;
        }

        /// <summary>
        /// Check if the user already exist in the list.
        /// </summary>
        /// <param name="users">List of the current users.</param>
        /// <param name="newUser">New user passed as a object in a json.</param>
        /// <returns>True or False.</returns>
        public bool ValidateDuplicade(List<User> users, User newUser)
        {
            var isDuplicated = false;

            foreach (var user in users)
            {
                    if (user.Email == newUser.Email
                        ||
                        user.Phone == newUser.Phone)
                    {
                        isDuplicated = true;
                    }
                    else if (user.Name == newUser.Name)
                    {
                        if (user.Address == newUser.Address)
                        {
                            isDuplicated = true;
                        }
                    }
            }

            return isDuplicated;
        }
    }
}
