// --------------------------------------------------------------------------------------------------------------------
// <copyright file=LazyInitialization.cs" company="Bridgelabz">
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
    /// Class for Lazy Initialization
    /// </summary>
    public class LazyInitialization
    {
        /// <summary>
        /// The object
        /// </summary>
        private static LazyInitialization obj;
        static int count = 0;
        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
        {
            count++;
            Console.WriteLine("Objct Created");
        }
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static LazyInitialization GetInstance
        {
            get
            {
                if (obj == null)
                {
                    obj = new LazyInitialization();
                }
                Console.WriteLine("Message ");
                return obj;
            }           
        }
    }      
}
