// <copyright file="FactoryProducer.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    /// <summary>
    /// This class used as factory producer.
    /// </summary>
    public class FactoryProducer
    {
        /// <summary>
        /// This method used for get sub factory.
        /// </summary>
        /// <param name="inUse">Boolean os use.</param>
        /// <returns>Factory object.</returns>
        public static AbastractFactory GetFactory(bool inUse)
        {
            if (inUse)
            {
                return new OsFactory();
            }
            else
            {
                return new MinUseOsFactory();
            }
        }
    }
}
