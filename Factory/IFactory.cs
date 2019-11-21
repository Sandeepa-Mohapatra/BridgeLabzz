// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IFactory.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Factory
{
    /// <summary>
    ///Product Interface which have the abstract method
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Method declaration
        /// This will Count the specified Stuff.
        /// </summary>
        /// <param name="n">The n.</param>
        void Count(int n);
    }
}
