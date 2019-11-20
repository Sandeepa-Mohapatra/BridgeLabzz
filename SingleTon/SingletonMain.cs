// --------------------------------------------------------------------------------------------------------------------
// <copyright file=SingletonMain.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms.SingleTon
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for Singlerton design pattern which contain all its types
    /// </summary>
    class SingletonMain
    {
        /// <summary>
        /// Method
        /// </summary>
        public void Method()
        {
            Console.WriteLine("Enter the no of the program which you wnat to run");
            Console.WriteLine("Eager Initialization(1)");
            Console.WriteLine("Lazy Initialization(2)");
            Console.WriteLine("Threadsafe(3)");
            ///Take the user input
            int n = int.Parse(Console.ReadLine());
            ///Options
            switch(n)
            {
                case 1:
                    EagerInitialization a = EagerInitialization.Obj;
                    a.Message("Implemented successfully");
                    break;
                case 2:
                    LazyInitialization b=LazyInitialization.GetInstance;
                    break;
                case 3:
                    Threadsafe c = Threadsafe.GetInstance;
                    break;
            }
        }
    }
}
