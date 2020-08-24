// <copyright file="ColdDrink.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// This class used for get cold drink.
    /// </summary>
    public class ColdDrink : IMealItem
    {
        /// <summary>
        /// This method give name of item.
        /// </summary>
        /// <returns>String name.</returns>
        public string Name()
        {
            return "Cold drink";
        }

        /// <summary>
        /// This method give packing type.
        /// </summary>
        /// <returns>Packing object.</returns>
        public IPacking Packing()
        {
            return new Bottle();
        }

        /// <summary>
        /// This method give price of item.
        /// </summary>
        /// <returns>Double price.</returns>
        public double Price()
        {
            return 10.0;
        }
    }
}
