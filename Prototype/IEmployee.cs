// --------------------------------------------------------------------------------------------------------------------
// <copyright file=IEmployee.cs" company="Bridgelabz">
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
    /// Interface
    /// </summary>
    public interface IEmployee
    {
        IEmployee Clone();
        string GetDetails();
    }
}
