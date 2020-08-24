// <copyright file="AbastractFactory.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    using FactoryPattern;

    /// <summary>
    /// This abstract class used as abstract factory.
    /// </summary>
    public abstract class AbastractFactory
    {
        /// <summary>
        /// This abstract method used for get os type.
        /// </summary>
        /// <param name="type">String os type.</param>
        /// <returns>Os.</returns>
        public abstract IOperatingSystem GetOs(string type);
    }
}
