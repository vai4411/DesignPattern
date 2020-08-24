// <copyright file="OsFactory.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    using FactoryPattern;

    /// <summary>
    /// This is factory class.
    /// </summary>
    public class OsFactory : AbastractFactory
    {
        /// <summary>
        /// This method used for get os.
        /// </summary>
        /// <param name="type">Os type.</param>
        /// <returns>Os object.</returns>
        public override IOperatingSystem GetOs(string type)
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
