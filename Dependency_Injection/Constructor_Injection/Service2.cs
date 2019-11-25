// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Service2.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Dependency_Injection.Constructor_Injection
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// class which implements interface
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Dependency_Injection.Constructor_Injection.IService" />
    class Service2 :IService
    {
        /// <summary>
        /// Displays the message.
        /// </summary>
        public void Display()
        {
            Console.WriteLine("second Service");
        }
    }
}
