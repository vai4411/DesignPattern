// <copyright file="Ios.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FactoryPattern
{
    using System;

    /// <summary>
    /// This is ios class.
    /// </summary>
    public class Ios : IOperatingSystem
    {
        /// <summary>
        /// This is spec method.
        /// </summary>
        public void Spec()
        {
            Console.WriteLine("secure os");
        }
    }
}
