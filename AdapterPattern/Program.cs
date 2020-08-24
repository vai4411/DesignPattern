// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdapterPattern
{
    using System;

    /// <summary>
    /// This class contains main method.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is main method.
        /// </summary>
        public static void Main()
        {
            Sparrow sparrow = new Sparrow();
            IToy toy = new ToyDuck();

            ToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.Fly();
            sparrow.MakeSound();

            Console.WriteLine("ToyDuck...");
            toy.Squeak();

            Console.WriteLine("BirdAdapter...");
            birdAdapter.Squeak();
        }
    }
}
