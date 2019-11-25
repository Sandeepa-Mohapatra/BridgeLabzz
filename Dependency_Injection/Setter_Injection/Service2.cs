// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Service2.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Dependency_Injection.Setter_Injection
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Service2:IService
    {
        public void Display()
        {
            Console.WriteLine("Second Service");
        }
    }
}
