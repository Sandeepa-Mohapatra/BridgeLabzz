// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Operations.cs" company="Bridgelabz">
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
    class Operations : InventoryManager
    {
        public void Add()
        {
            //User will give the data
            Console.WriteLine("Enter name");
            String s = Console.ReadLine();
            Console.WriteLine("Enter weight");
            int w = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price per kg");
            int p= int.Parse(Console.ReadLine());
            ///Passing the values to create object
            InventoryModel.CreateObject(s, w, p);
  
        }
        public void Display()
        {
            //JSON file path
            string path = (@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\Inventory_Management\InventoryData.json");
            //Serializing JSON object
            StreamReader read = new StreamReader(path);
            //Read all characters from the current position to the end of the Stream
            var json = read.ReadToEnd();
            var item = JsonConvert.DeserializeObject<List<InventoryModel>>(json);
            Console.WriteLine("Name\tWeight\tPrice(per kg)\tAmount");
            ///This will calculate the price and print 
            foreach (var i in item)
            {
                Console.WriteLine(i.Name + "\t" + i.Weight + "\t" + i.PricePerKg + "\t" + (i.Weight * i.PricePerKg));
            }
        }

    }
}
