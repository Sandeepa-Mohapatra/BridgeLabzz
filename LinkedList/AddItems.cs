// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AddItems.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class AddItems
    {
        public void Add()
        {
            Utility u = new Utility();
            //User will give the data
            Console.WriteLine("If you want to enter other share then enter the company name first");
            String n = Console.ReadLine();
            Console.WriteLine("Enter no of share");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price");
            int p = int.Parse(Console.ReadLine());
            
            ///Passing the values to create object
            CompanyModel.CreateObject(n, s, p);
        }
    }
}
