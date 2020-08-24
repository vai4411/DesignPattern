// <copyright file="ToyDuck.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdapterPattern
{
    using System;

    /// <summary>
    /// This class used for toy duck object.
    /// </summary>
    public class ToyDuck : IToy
    {
        /// <summary>
        /// This is squeak method.
        /// </summary>
        public void Squeak()
        {
            Console.WriteLine("Toy sound...");
        }
    }
}
