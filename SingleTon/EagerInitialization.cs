// --------------------------------------------------------------------------------------------------------------------
// <copyright file=EagerInitialization.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.SingleTon
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Class for Eager initialization design pattern 
    /// </summary>
    class EagerInitialization
    {
        /// <summary>
        /// The objcount count the no of object
        /// </summary>
        static int objcount = 0;
        /// <summary>
        /// here the object of EagerInitialization created
        /// </summary>
        private static readonly EagerInitialization obj = new EagerInitialization();
        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
        {
            objcount++;
            Console.WriteLine("Objct Created");
        }
        /// <summary>
        /// Gets the object.
        /// </summary>
        /// <value>
        /// The object.
        /// </value>
        public static EagerInitialization Obj
        {
            get
            {
                return obj;
            }
        }
        /// <summary>
        /// Messages the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Message(string message)
        {
            Console.WriteLine("Message " + message);
        }
    }
}
