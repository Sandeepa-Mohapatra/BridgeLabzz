// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Client.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Adapter
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Client class
    /// </summary>
    class Client
    {
        private ITarget x;
        /// <summary>
        /// Initializes a new instance of the <see cref="Client"/> class.
        /// </summary>
        /// <param name="y">y</param>
        public Client(ITarget y)
        {
            this.x = y;                    
        }
        /// <summary>
        /// Shows names.
        /// </summary>
        public void ShowName()
        {
            String[] name = x.GetStudentName();
            Console.WriteLine("......Wellcome To Office.....");
            foreach (String item in name)
            {
                Console.WriteLine(item);
            }
        }
    }
}
