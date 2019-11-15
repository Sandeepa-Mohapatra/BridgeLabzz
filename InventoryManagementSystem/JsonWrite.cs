// --------------------------------------------------------------------------------------------------------------------
// <copyright file=JsonWrite.cs" company="Bridgelabz">
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
    class JsonWrite
    {
        public static void Write(JsonRead read)
        {
            //Json file path
            String path = (@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\InventoryManagementSystem\InventoryData.json");
            //Serialization
            var write = JsonConvert.SerializeObject(read);
            StreamWriter stream = new StreamWriter(path);
            //Clear the file
            stream.Flush();
            //Write data to file
            stream.Write(write);
            //closing
            stream.Close();
            
        }
    }
}
