// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Threadsafe.cs" company="Bridgelabz">
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
    /// Class for Thread safe initialization
    /// </summary>
    class Threadsafe
    {
        /// <summary>
        /// The object is initialized to null
        /// </summary>
        private static Threadsafe obj = null;
        /// <summary>
        /// Prevents a default instance of the <see cref="Threadsafe"/> class from being created.
        /// </summary>
        private Threadsafe() { }
        /// <summary>
        /// The object is created
        /// </summary>
        private static object lockThis = new object();
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static Threadsafe GetInstance
        {
            get
            {                
               lock (lockThis)
               {
                  if (obj == null)
                     obj = new Threadsafe();

                  return obj;
               }
            }
        }       
    }
}
