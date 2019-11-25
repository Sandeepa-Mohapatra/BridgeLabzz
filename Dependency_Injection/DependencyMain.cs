// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DependencyMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPtternPrograms.Dependency_Injection
{
    /// <summary>
    /// class for DependencyMain
    /// </summary>
    class DependencyMain
    {
        /// <summary>
        /// Choices this instance.
        /// </summary>
        public void Choice()
        {
            Console.WriteLine("Enter the no according to the types of dependency injection");
            Console.WriteLine("Constructor Injection(1)");
            Console.WriteLine("Setter Injection(2)");
            Console.WriteLine("Method Injection(3)");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Constructor_Injection.Service1 s = new Constructor_Injection.Service1();
                    Constructor_Injection.Client c = new Constructor_Injection.Client(s);

                    Constructor_Injection.Service2 s1 = new Constructor_Injection.Service2();
                     c = new Constructor_Injection.Client(s1);
                    break;
                case 2:
                    Setter_Injection.Service1 t = new Setter_Injection.Service1();
                    Setter_Injection.Client c1 = new Setter_Injection.Client();
                    c1.L= t;
                    Setter_Injection.Service2 t1 = new Setter_Injection.Service2();
                    c1.L = t1;
                    break;
                case 3:
                    Method_Injection.Service1 u = new Method_Injection.Service1();
                    Method_Injection.Client c2 = new Method_Injection.Client();
                    c2.Service(u);
                    Method_Injection.Service1 u1 = new Method_Injection.Service1();
                    c2.Service(u1);
                    break;
            }
        }
    }
}
