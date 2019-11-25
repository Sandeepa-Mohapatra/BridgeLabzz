// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Client.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.Dependency_Injection.Setter_Injection
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Client
    {
        private IService l;
        public IService L
        {
            set { this.l = value; }
        }
        public void Serve() 
        { 
            this.l.Display();
        }
    }
}

