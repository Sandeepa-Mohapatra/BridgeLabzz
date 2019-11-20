// --------------------------------------------------------------------------------------------------------------------
// <copyright file=JsonRead.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.AddressBook
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class JsonRead
    {
        //Encapsulation concept is used here        
        private List<AddressBookModel> addressList = new List<AddressBookModel>();
        public List<AddressBookModel> AddressList { get; set; }
    }
}
