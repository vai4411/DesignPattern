// <copyright file="Sparrow.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdapterPattern
{
    using System;

    /// <summary>
    /// This class used for get sparrow object.
    /// </summary>
    public class Sparrow : IBird
    {
        /// <summary>
        /// This method used for fly.
        /// </summary>
        public void Fly()
        {
            Console.WriteLine("flying...");
        }

        /// <summary>
        /// This method used for make sound.
        /// </summary>
        public void MakeSound()
        {
            Console.WriteLine("chirp chirp...");
        }
    }
}
