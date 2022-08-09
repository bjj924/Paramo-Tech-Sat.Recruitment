// <copyright file="UserType.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Sat.Recruitment.Negocio.Helpers.User
{
    using System;
    using Sat.Recruitment.Model.Interfaces.UsersLogic;

    /// <summary>
    /// Class that get the plus in money by user type.
    /// </summary>
    public class UserType : IUserType
    {
        /// <summary>
        /// Method that return the plus in the money by type of user.
        /// </summary>
        /// <param name="money">Decimal value with the current money of the user.</param>
        /// <param name="userType">String value with the type user.</param>
        /// <returns>The new value of the money by the type of user.</returns>
        public decimal MoneyByUserType(decimal money, string userType)
        {
            switch (userType)
            {
                case "Normal":
                    money = this.GetGifNormal(money);
                    break;

                case "SuperUser":
                    money = this.GetGifSuper(money);
                    break;

                case "Premium":
                    money = this.GetGifPremium(money);
                    break;

                default:
                    break;
            }

            return money;
        }

        private decimal GetGifNormal(decimal money)
        {
            if (money > 100)
            {
                var percentage = Convert.ToDecimal(0.12);

                // If new user is normal and has more than USD100
                var gif = money * percentage;
                money = money + gif;
            }
            else
            {
                if (money > 10)
                {
                    var percentage = Convert.ToDecimal(0.8);
                    var gif = money * percentage;
                    money = money + gif;
                }
            }

            return money;
        }

        private decimal GetGifSuper(decimal money)
        {
            if (money > 100)
            {
                var percentage = Convert.ToDecimal(0.20);
                var gif = money * percentage;
                money = money + gif;
            }

            return money;
        }

        private decimal GetGifPremium(decimal money)
        {
            if (money > 100)
            {
                var gif = money * 2;
                money = money + gif;
            }

            return money;
        }
    }
}
