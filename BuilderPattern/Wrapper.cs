// <copyright file="Wrapper.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// This class used for get wrapper.
    /// </summary>
    public class Wrapper : IPacking
    {
        /// <summary>
        /// This method used for wapper.
        /// </summary>
        /// <returns>String wrapper.</returns>
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
