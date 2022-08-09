// <copyright file="User.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Model.Models
{
    /// <summary>
    /// Class that contains the model for the user object.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or sets string that contains the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets string that contains the Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets string that contains the Address.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets string that contains the Phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets string that contains the UserType.
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// Gets or sets decimal that contains the Money.
        /// </summary>
        public decimal Money { get; set; }
    }
}
