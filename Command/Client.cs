// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Client.cs" company="Bridgelabz">
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
    /// Client Class
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Runs the command.
        /// </summary>
        public void RunCommand()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            ConcretCommand command = new ConcretCommand(receiver);
            command.Parameter = "Command Design Pattern implemented successfuly";
            invoker.Command = command;
            invoker.ExecuteCommand();
        }
    }
}
