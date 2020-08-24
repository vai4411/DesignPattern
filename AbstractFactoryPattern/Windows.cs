// <copyright file="Windows.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    using System;
    using FactoryPattern;

    /// <summary>
    /// This class used for get windows object.
    /// </summary>
    public class Windows : IOperatingSystem
    {
        /// <summary>
        /// This method used for get spec of os.
        /// </summary>
        public void Spec()
        {
            Console.WriteLine("about to die");
        }
    }
}
