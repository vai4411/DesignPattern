// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
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
            Console.WriteLine("Meal...");
            Burger burger = new Burger();
            ColdDrink coldDrink = new ColdDrink();
            Console.WriteLine("Item    : " + burger.Name());
            Console.WriteLine("packing : " + burger.Packing());
            Console.WriteLine("price   : " + burger.Price());
            Console.WriteLine("Item    : " + coldDrink.Name());
            Console.WriteLine("packing : " + coldDrink.Packing());
            Console.WriteLine("price   : " + coldDrink.Price());
        }
    }
}
