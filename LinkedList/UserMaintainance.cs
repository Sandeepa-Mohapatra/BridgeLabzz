// --------------------------------------------------------------------------------------------------------------------
// <copyright file=UserMaintainance.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class UserMaintainance
    {
        Utility u = new Utility();
        public void MaintainDetails()
        {
            var data = JsonReadfile.Read();
            foreach(var i in data.File)
            {
                u.Insert(i.Numberofshare);
            }           
            AddItems a = new AddItems();
            a.Add();
        }
    }
}
