// <copyright file="Local.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    using System;
    using FactoryPattern;

    /// <summary>
    /// This class used for local os.
    /// </summary>
    public class Local : IOperatingSystem
    {
        /// <summary>
        /// This method used for get specs.
        /// </summary>
        public void Spec()
        {
            Console.WriteLine("Local os");
        }
    }
}
