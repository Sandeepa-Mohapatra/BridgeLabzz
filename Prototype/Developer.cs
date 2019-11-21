// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Developer.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Prototype
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    ///ConcretePrototype Class
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Prototype.IEmployee" />
    class Developer :IEmployee
    {
        /// <summary>
        /// Gets and sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        public string Designation { get; set; }
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public IEmployee Clone()
        {
            // only top-level objects are duplicated
            return (IEmployee)MemberwiseClone();
        }
        /// <summary>
        /// Returns the details.
        /// </summary>
        /// <returns></returns>
        public string GetDetails()
        {
            return string.Format("{0} - {1}", Name, Designation);
        }
    }
}
