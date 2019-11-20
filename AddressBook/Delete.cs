// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Delete.cs" company="Bridgelabz">
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
    /// Class for delete
    /// </summary>
    class Delete
    {
        /// <summary>
        /// Method to delet a particular data
        /// </summary>
        public void DeleteData()
        {
            Console.WriteLine("Enter the name , whose address you want to delet");
            ///Taking the user input
            String n = Console.ReadLine();
            ///Reading the json file
            var d = JsonReadfile.Read();
            foreach(var i in d.AddressList)
            {
                ///finding the list
                if(i.Name.Equals(n))
                {
                    ///Remove the data from the list
                    d.AddressList.Remove(i);
                    break;
                }
            }
            ///Write the modified data to the json file again
            JsonWrite.Write(d);
            ///Printing messege
            Console.WriteLine("Your data has been deleted succesfully");
            Console.WriteLine("Thank you.....");
        }
    }
}
