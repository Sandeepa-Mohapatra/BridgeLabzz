// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ConcreteSubject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------



namespace DesignPtternPrograms.ObserverPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class which inherit subject class
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.ObserverPattern.Subject" />
    public class ConcreteSubject : Subject
    {
        private string state;
        /// <summary>
        /// Gets the state.
        /// </summary>
        /// <returns>state</returns>
        public string GetState()
        {
            return state;
        }
        /// <summary>
        /// Sets the state.
        /// </summary>
        /// <param name="newState">The new state.</param>
        public void SetState(string newState)
        {
            state = newState;
            Notify();
        }
    }
}
