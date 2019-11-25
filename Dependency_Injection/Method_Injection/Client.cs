// --------------------------------------------------------------------------------------------------------------------
// <copyright file=client.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Dependency_Injection.Method_Injection
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// client class
    /// </summary>
    class Client
    {      
        public void Service(IService k1)
        {
            k1.Display();
        }
    }
}
