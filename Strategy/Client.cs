// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Client.cs" company="Bridgelabz">
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
    /// Client class
    /// </summary>
    class Client
    {
        private IStrategy s;
        /// <summary>
        /// Sets the strategy.
        /// </summary>
        /// <param name="s2">Object</param>
        public void SetStrategy(IStrategy s2)
        {
            this.s = s2;
        }
        /// <summary>
        /// Displays the result.
        /// </summary>
        public void Display()
        {            
            double sum = this.s.Algorithm(5);
            Console.WriteLine("Squre of 5 is: {0}",sum);
        }
    }
}
