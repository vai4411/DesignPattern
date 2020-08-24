// <copyright file="IMealItem.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BuilderPattern
{
    /// <summary>
    /// This interface used for get meal item.
    /// </summary>
    public interface IMealItem
    {
        /// <summary>
        /// This method give item name.
        /// </summary>
        /// <returns>String name.</returns>
        string Name();

        /// <summary>
        /// This method give packing object.
        /// </summary>
        /// <returns>Packing object.</returns>
        IPacking Packing();

        /// <summary>
        /// This method give item price.
        /// </summary>
        /// <returns>Double price.</returns>
        double Price();
    }
}
