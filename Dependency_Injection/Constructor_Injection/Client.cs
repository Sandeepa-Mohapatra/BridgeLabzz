// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Client.cs" company="Bridgelabz">
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
    /// Client class
    /// </summary>
    class Client
    {
        private IService o;
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="s">The s.</param>
        public Client(IService s)
        {
            this.o = s;
        }
        /// <summary>
        /// Services this instance.
        /// </summary>
        public void Service()
        {
            this.o.Display();
        }
    }
}
