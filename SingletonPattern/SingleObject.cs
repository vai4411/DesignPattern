// <copyright file="SingleObject.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SingletonPattern
{
    using System;

    /// <summary>
    /// This class used for get single object.
    /// </summary>
    public class SingleObject
    {
        private static readonly SingleObject Object = new SingleObject();

        private SingleObject()
        {
        }

        /// <summary>
        /// This method used for get new object instance.
        /// </summary>
        /// <returns>Object instance.</returns>
        public static SingleObject GetObject()
        {
            return Object;
        }

        /// <summary>
        /// This method used for get message.
        /// </summary>
        public void ShowMessage()
        {
            Console.WriteLine("hello this is singleton object");
        }
    }
}
