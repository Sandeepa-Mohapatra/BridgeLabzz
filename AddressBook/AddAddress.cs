// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AddAddress.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for adding new  data
    /// </summary>
    class AddAddress
    {
        /// <summary>
        /// method for performing the operation
        /// </summary>
        public void Addr()
        {
            ///Taking user input
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter your State");
            String state = Console.ReadLine();
            Console.WriteLine("Enter your District");
            String dist = Console.ReadLine();
            Console.WriteLine("Enter your Phone no.");
            int phone = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your Email");
            String email = Console.ReadLine();
            ///Calling the method to add new data to the json file
            AddressBookModel.CreatObject(name, state, dist, phone, email);
            ///Creating object
            Display d = new Display();
            ///Calling display method to display the new list
            d.DisplayList();
        }
    }
}
