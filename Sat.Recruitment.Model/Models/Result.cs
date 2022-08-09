// <copyright file="Result.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Model.Models
{
    /// <summary>
    /// Class that contains the model for the result.
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Gets or sets a value indicating whether bool if the result is Error or a OK.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Gets or sets string that contains the error message.
        /// </summary>
        public string Errors { get; set; }
    }
}
