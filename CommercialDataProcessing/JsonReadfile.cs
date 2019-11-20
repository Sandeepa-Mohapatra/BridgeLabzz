// --------------------------------------------------------------------------------------------------------------------
// <copyright file=JsonReadFile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.CommercialDataProcessing
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
   static class JsonReadfile
    {
        /// <summary>
        /// This will read the data from the json file
        /// </summary>
        /// <returns></returns>
        public static NewAccount Read()
        {
            //JSON file path
            String path = (@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\CommercialDataProcessing\AccountStockFile.json");
            //Serializing JSON object
            StreamReader s = new StreamReader(path);
            //Read all characters from the current position to the end of the Stream
            var json = s.ReadToEnd();
            //Deserialization
            var d = JsonConvert.DeserializeObject<NewAccount>(json);
            //Closing StreamReader
            s.Close();
            return d;
        }
    }
}
