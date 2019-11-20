// --------------------------------------------------------------------------------------------------------------------
// <copyright file=JsonRead.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.InventoryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class JsonRead
    {
        //Encapsulation concept is used here        
        private List<InventoryModel> accountList = new List<InventoryModel>();
        public List<InventoryModel> AccountList { get; set; }
    }
}
