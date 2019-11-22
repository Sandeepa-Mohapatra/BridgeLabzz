// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ConcretStrategy1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Strategy
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// ConcreteStategy Class
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Strategy.IStrategy" />
    class ConcretStrategy1 :IStrategy
    {
        /// <summary>
        /// finds the square of n.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public double Algorithm(int n)
        {
            double x = Math.Pow(n, 2);
            return x;
        }
    }
}
