// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ConcretCommand.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Command
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class ConcretCommand :ICommand
    {        
        protected Receiver receiver1;
        public string Parameter { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcretCommand"/> class.
        /// </summary>
        /// <param name="receiver">The receiver.</param>
        public ConcretCommand(Receiver receiver)
        {
            receiver1 = receiver;
        }
        /// <summary>
        /// Executes this instance.
        /// </summary>
        public void Execute()
        {
            receiver1.Action(Parameter);
        }
    }
}
