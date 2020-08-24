// <copyright file="IBird.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdapterPattern
{
    /// <summary>
    /// This interface used for get bird objects.
    /// </summary>
    public interface IBird
    {
        /// <summary>
        /// This is fly method.
        /// </summary>
        public void Fly();

        /// <summary>
        /// This is make sound method.
        /// </summary>
        public void MakeSound();
    }
}
