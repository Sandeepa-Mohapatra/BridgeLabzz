// --------------------------------------------------------------------------------------------------------------------
// <copyright file=ConcreteObserver.cs" company="Bridgelabz">
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
    /// This class implements ovserver
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.ObserverPattern.IObserver" />
    class ConcreteObserver : IObserver
    {
        private ConcreteSubject subject;
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteObserver"/> class.
        /// </summary>
        /// <param name="sub">object.</param>
        public ConcreteObserver(ConcreteSubject sub)
        {
            subject = sub;
        }
        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            string subjectState = subject.GetState();
            Console.WriteLine(subjectState);
        }
    }
}
