// --------------------------------------------------------------------------------------------------------------------
// <copyright file=AddressBookModel.cs" company="Bridgelabz">
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
    /// Class for Model
    /// </summary>
    class AddressBookModel
    {
        private String name;
        private String state;
        private String dist;
        private String email;
        private long phone;
        /// <summary>
        /// constructor for initializing values given by user
        /// </summary>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="dist"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public AddressBookModel(String name,String state,String dist,long phone,String email)
        {
            this.name = name;
            this.dist = dist;
            this.state = state;
            this.phone = phone;
            this.email = email;
        }
        /// <summary>
        /// Get value from json file and set them 
        /// </summary>
        public string Name
        {
            get {return this.name; }
            set {this.name=value; }
        }
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public string Dist
        {
            get { return this.dist; }
            set { this.dist = value; }
        }
        public long Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        /// <summary>
        /// Creating a new object using this model by getting the user value
        /// </summary>
        /// <param name="name"></param>
        /// <param name="state"></param>
        /// <param name="dist"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public static void CreatObject(string name, string state, string dist, long phone, string email)
        {
            AddressBookModel a = new AddressBookModel(name,state,dist,phone,email);
            ///Reading json file
            var d = JsonReadfile.Read();
            ///Adding new data to the list
            d.AddressList.Add(a);
            ///Writting the new modified list to the json file
            JsonWrite.Write(d);
        }

    }
}
