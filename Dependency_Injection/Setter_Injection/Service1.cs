// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Service1.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Dependency_Injection.Setter_Injection
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class
    /// </summary>
    /// <seealso cref="DesignPtternPrograms.Dependency_Injection.Setter_Injection.IService" />
    class Service1 :IService
    {
        public void Display()
        {
            Console.WriteLine("First Service");
        }
    }
}
