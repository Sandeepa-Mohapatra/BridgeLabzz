using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPtternPrograms.SingleTon
{
    class SingletonMain
    {
        public void Method()
        {
            Console.WriteLine("Enter the no of the program which you wnat to run");
            Console.WriteLine("Eager Initialization(1)");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    EagerInitialization a = EagerInitialization.Obj;
                    a.Message("Implemented successfully");
                    break;
            }
        }
    }
}
