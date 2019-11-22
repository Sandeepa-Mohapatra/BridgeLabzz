// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Subject.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.ObserverPattern
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Subject
    /// </summary>
    public abstract class Subject
        {
        private ArrayList observers = new ArrayList();
        /// <summary>
        /// Attaches the specified object.
        /// </summary>
        /// <param name="o">The o.</param>
        public void Attach(IObserver o)
            {
                observers.Add(o);
            }
        /// <summary>
        /// Detaches the specified object.
        /// </summary>
        /// <param name="o">The o.</param>
        public void Detach(IObserver o)
            {
                observers.Remove(o);
            }
        /// <summary>
        /// Notifies this instance.
        /// </summary>
        public void Notify()
            {
                foreach (IObserver o in observers)
                {
                    o.Update();
                }
            }
        }    
}
