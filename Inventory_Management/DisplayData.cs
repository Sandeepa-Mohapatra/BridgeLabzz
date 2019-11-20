// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DisplayData.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.Inventory_Management
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using Newtonsoft.Json;    
    /// <summary>
    /// Class to fetch data and display
    /// </summary>
    class DisplayData
    {
        /// <summary>
        /// Method to Display
        /// </summary>
        public void Display()
        {
            //JSON file path
            string path=(@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\Inventory_Management\Inventory.json");
            //Serializing JSON object
            StreamReader read = new StreamReader(path);
            //Read all characters from the current position to the end of the Stream
            var json = read.ReadToEnd();
            var item = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
            Console.WriteLine("Name\tWeight\tPrice(per kg)\tAmount");
            ///This will calculate the price and print 
            foreach(var i in item)
            {
                Console.WriteLine(i.Name+"\t"+i.Weight+"\t"+i.PricePerKg + "\t"+(i.Weight*i.PricePerKg));
            }
        }        
    }
}
