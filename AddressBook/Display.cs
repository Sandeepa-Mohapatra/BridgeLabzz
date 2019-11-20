// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Display.cs" company="Bridgelabz">
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
    /// This class will display the list from the json file
    /// </summary>
    class Display
    {
        /// <summary>
        /// Method for display
        /// </summary>
        public void DisplayList()
        {
            ///Read the json file
            var d = JsonReadfile.Read();
            ///Storing the list in a variable locally
            List<AddressBookModel> model = d.AddressList;
            ///Displaying the data
            foreach (AddressBookModel i in model)
            {
                Console.WriteLine();
                Console.WriteLine("Name: "+i.Name);
                Console.WriteLine("State: " + i.State);
                Console.WriteLine("District" + i.Dist);
                Console.WriteLine("Phone no.: " + i.Phone);
                Console.WriteLine("Email: " + i.Email);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
