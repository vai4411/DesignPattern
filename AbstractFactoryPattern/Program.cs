// <copyright file="Program.cs" company="Bridgelabz">
// Copyright (c) Bridgelabz. All rights reserved.
// </copyright>

namespace AbstractFactoryPattern
{
    using FactoryPattern;

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
            AbastractFactory factory = FactoryProducer.GetFactory(true);
            IOperatingSystem os1 = factory.GetOs("android");
            os1.Spec();
            IOperatingSystem os2 = factory.GetOs("ios");
            os2.Spec();
            AbastractFactory factory1 = FactoryProducer.GetFactory(false);
            IOperatingSystem os3 = factory1.GetOs("android");
            os3.Spec();
            IOperatingSystem os4 = factory1.GetOs("ios");
            os4.Spec();
        }
    }
}
