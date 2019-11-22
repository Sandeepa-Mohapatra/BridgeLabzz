
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Invoker.cs" company="Bridgelabz">
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
    /// Invoker class
    /// </summary>
    class Invoker
    {
        public ICommand Command { get; set; }
        /// <summary>
        /// Executes the command.
        /// </summary>
        public void ExecuteCommand()
        {
            Command.Execute();
        }
    }
}
