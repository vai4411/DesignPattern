// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SingletonPattern
{
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
            SingleObject singleObject = SingleObject.GetObject();
            singleObject.ShowMessage();
        }
    }
}
