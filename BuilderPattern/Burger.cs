// <copyright file="Burger.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// This class used for get burger.
    /// </summary>
    public class Burger : IMealItem
    {
        /// <summary>
        /// This method give item name.
        /// </summary>
        /// <returns>String name.</returns>
        public string Name()
        {
            return "Burger";
        }

        /// <summary>
        /// This method give packing type.
        /// </summary>
        /// <returns>Packing object.</returns>
        public IPacking Packing()
        {
            return new Wrapper();
        }

        /// <summary>
        /// This method give price.
        /// </summary>
        /// <returns>Double Price.</returns>
        public double Price()
        {
            return 50.0;
        }
    }
}
