// <copyright file="ReadFile.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Negocio.Helpers.User
{
    using System.Collections.Generic;
    using System.IO;
    using Sat.Recruitment.Model.Interfaces.UsersLogic;
    using Sat.Recruitment.Model.Models;

    /// <summary>
    /// Class that contains the method to read a txt file
    /// with the list of users.
    /// </summary>
    public class ReadFile : IReadFile
    {
        /// <summary>
        /// Read a file in the solution that contains a list of users.
        /// </summary>
        /// <returns>The stream reader of the list of user in a file.</returns>
        public List<User> ListOfUsersFromFile()
        {
            var listOfUser = new List<User>();

            var path = Directory.GetCurrentDirectory() + "/Files/Users.txt";

            using (var fileStream = new FileStream(path, FileMode.Open))
            {
                using (var reader = new StreamReader(fileStream))
                {
                    while (reader.Peek() >= 0)
                    {
                        var line = reader.ReadLineAsync().Result;
                        var user = new User
                        {
                            Name = line.Split(',')[0].ToString(),
                            Email = line.Split(',')[1].ToString(),
                            Phone = line.Split(',')[2].ToString(),
                            Address = line.Split(',')[3].ToString(),
                            UserType = line.Split(',')[4].ToString(),
                            Money = decimal.Parse(line.Split(',')[5].ToString()),
                        };

                        listOfUser.Add(user);
                    }
                }
            }

            return listOfUser;
        }
    }
}
