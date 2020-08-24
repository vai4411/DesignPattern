// <copyright file="Bottle.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// This class used for bottle packing.
    /// </summary>
    public class Bottle : IPacking
    {
        /// <summary>
        /// This method is used for get packing type.
        /// </summary>
        /// <returns>Bottle.</returns>
        public string Pack()
        {
            return "Bottle";
        }
    }
}
