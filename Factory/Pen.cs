// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Pen.cs" company="Bridgelabz">
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
    /// Product Class for pen which implements interface
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Factory.IFactory" />
    class Pen :IFactory
    {
        /// <summary>
        /// This will Count the specified Stuff.
        /// </summary>
        /// <param name="n">The n.</param>
        void IFactory.Count(int n)
        {
            Console.WriteLine("You have {0} pens",n);
        }
    }
}
