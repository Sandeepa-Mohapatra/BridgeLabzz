
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryManager.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.InventoryManagementSystem
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class InventoryManager
    {
        public void Operation()
        {
            //Options for user
            Console.WriteLine("Enter what Operation you want to perform");
            Console.WriteLine("Add Item(1)");
            Console.WriteLine("Delete Data(2)");
            Console.WriteLine("Calculate the total parice(3)");
            //Taking the option as input
            int n=int.Parse(Console.ReadLine());
            //Creating object
            Operations a = new Operations();
            switch (n)
            {
                case 1:
                    a.Add();
                    Console.WriteLine("Item added Properly.....");
                    Console.WriteLine("Thank you.....");
                    break;

                case 2:
                    a.Delete();
                    Console.WriteLine("Item deleted Properly.....");
                    Console.WriteLine("Thank you.....");
                    break;
                case 3:
                    Console.WriteLine("Here you go....");
                    a.Display();
                    Console.WriteLine("Thank you.....");
                    break;
            }           
        }        
    }    
}
