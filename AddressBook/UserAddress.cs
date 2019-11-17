// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserAddress.cs" company="Bridgelabz">
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
    /// Class for user
    /// </summary>
    class UserAddress
    {
        /// <summary>
        /// Method for all operations
        /// </summary>
        public void Operation()
        {
            ///Options for user
            Console.WriteLine("Enter 1 to See the adderss book");
            Console.WriteLine("Enter 2 to Add new details");
            Console.WriteLine("Enter 3 to delete from the list");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    Display d = new Display();
                    d.DisplayList();                                      
                    break;
                case 2:
                    AddAddress a = new AddAddress();
                    a.Addr();
                    break;
                case 3:
                    Delete b = new Delete();
                    b.DeleteData();
                    break;
            }
        }
    }
}
