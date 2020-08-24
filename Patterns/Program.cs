// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace FactoryPattern
{
    /// <summary>
    /// This is main class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// This is main method.
        /// </summary>
        /// <param name="args">String args.</param>
        public static void Main(string[] args)
        {
            OsFactory factory = new OsFactory();
            IOperatingSystem os = factory.GetOs("android");
            os.Spec();
        }
    }
}
