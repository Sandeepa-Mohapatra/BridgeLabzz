// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Receiver.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Command
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Reciever class
    /// </summary>
    class Receiver
    {
        /// <summary>
        /// Display the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Action(string message)
        {
            Console.WriteLine("This Pattern is", message);
        }
    }
}
