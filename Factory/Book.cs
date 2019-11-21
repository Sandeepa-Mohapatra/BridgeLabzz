// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Book.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Factory
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    ///Product Class for book which implement interface
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Factory.IFactory" />
    public class Book: IFactory
    {
        /// <summary>
        /// Counts the specified Stuff and display.
        /// </summary>
        /// <param name="n">The n.</param>
        void IFactory.Count(int n)
        {
            Console.WriteLine("You have {0} books",n);
        }
    }
}
