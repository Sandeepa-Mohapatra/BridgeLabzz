// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Runner.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------


namespace ObjectOrientedPrograms
{
    using System;
    
    class Runner
    {
        /// <summary>
        ///Execution will be started from this method
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            ///User will choose the program  here from the given options
            Console.WriteLine("Enter the no of the program which you want to run from the given programs");
            Console.WriteLine("Inventory Data Management(1)");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    ///Object is created and calling the method to perform the total operation
                    Inventory_Management.DisplayData a = new Inventory_Management.DisplayData();
                    a.Display();
                    break;
            }
            
        }

    }
}
