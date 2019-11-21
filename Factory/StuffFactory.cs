// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StuffFactory.cs" company="Bridgelabz">
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
    /// Creator Class which is an abstract class itself and contain an abstract method
    /// </summary>
    public abstract class StuffFactory
    {
        /// <summary>
        /// Method Declaration
        /// </summary>
        /// <param name="Stuff">The stuff.</param>
        /// <returns></returns>
        public abstract IFactory GetFactory(String Stuff);
    }    
}
