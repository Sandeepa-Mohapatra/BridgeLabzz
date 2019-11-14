// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.StockReport
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
   /// <summary>
   /// Class to Generate Stock report
   /// </summary>
    class StockDisplay
    {
        public void Display()
        {
            ///JSON file path
            string s = (@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\StockReport\StockDetails.json");
            ///Serialization json object
            StreamReader read = new StreamReader(s);
            //Read all characters from the current position to the end of the Stream
            var json = read.ReadToEnd();
            //Desirialization
            var s1 = JsonConvert.DeserializeObject<List<StockModel>>(json);
            Console.WriteLine("****Stock Report****");
            Console.WriteLine();
            //Generate the Stock report
            foreach (var i in s1)
            {
                Console.WriteLine("Name of the share: "+i.Stockname);
                Console.WriteLine("Number of share: "+i.Numberofshare);
                Console.WriteLine("Price of the share: "+i.Priceofshare);
                Console.WriteLine("Total Price is: "+i.Numberofshare*i.Priceofshare);
                Console.WriteLine();
            }
        }
    }
}
