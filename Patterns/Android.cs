// <copyright file="Android.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FactoryPattern
{
    using System;

    /// <summary>
    /// This is android class.
    /// </summary>
    public class Android : IOperatingSystem
    {
        /// <summary>
        /// This is spec method.
        /// </summary>
        public void Spec()
        {
            Console.WriteLine("popular os");
        }
    }
}
