// <copyright file="OsFactory.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FactoryPattern
{
    /// <summary>
    /// This is factory class.
    /// </summary>
    public class OsFactory
    {
        /// <summary>
        /// This method used for get the os object.
        /// </summary>
        /// <param name="type">Type of os.</param>
        /// <returns>Os object.</returns>
        public IOperatingSystem GetOs(string type)
        {
            if (type.Equals("android"))
            {
                return new Android();
            }
            else
            {
                return new Ios();
            }
        }
    }
}
