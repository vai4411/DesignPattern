// <copyright file="MinUseOsFactory.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    using FactoryPattern;

    /// <summary>
    /// This class used for get minimum use os factory.
    /// </summary>
    public class MinUseOsFactory : AbastractFactory
    {
        /// <summary>
        /// This method used for get minimum users os.
        /// </summary>
        /// <param name="type">Os type.</param>
        /// <returns>Os object.</returns>
        public override IOperatingSystem GetOs(string type)
        {
            if (type.Equals("windows"))
            {
                return new Windows();
            }
            else
            {
                return new Local();
            }
        }
    }
}
