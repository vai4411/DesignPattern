// <copyright file="BirdAdapter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace AdapterPattern
{
    /// <summary>
    /// This class used for bird adapter.
    /// </summary>
    public class BirdAdapter : ToyDuck
    {
        private readonly IBird bird;

        /// <summary>
        /// Initializes a new instance of the <see cref="BirdAdapter"/> class.
        /// </summary>
        /// <param name="bird">Bird object.</param>
        public BirdAdapter(IBird bird)
        {
            this.bird = bird;
        }

        /// <summary>
        /// This method used for get sound of bird.
        /// </summary>
        public new void Squeak()
        {
            this.bird.MakeSound();
        }
    }
}
