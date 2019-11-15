
// --------------------------------------------------------------------------------------------------------------------
// <copyright file=InventoryModel.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------


namespace ObjectOrientedPrograms.InventoryManagementSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class InventoryModel
    {
        private string name;
        private int weight;
        private int price;
        //Parameterize constructor
        public InventoryModel(string name,int weight,int price)
        {
            this.name = name;
            this.weight = weight;
            this.price = price;
        }
       
        //Getting and setting values
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int PricePerKg
        {
            get { return this.price; }
            set { this.price = value; }
        }
        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        /// <summary>
        ///This will perform the data fetching and adding to the file operation
        /// </summary>
        /// <param name="name"></param>
        /// <param name="weight"></param>
        /// <param name="price"></param>
        public static void CreateObject(string name,int weight,int price)
        {
            /// Creating object and
            /// calling cunstructor 
            InventoryModel model = new InventoryModel(name,weight,price);
            /// Read the json file
            var data = JsonReadfile.Read();
            /// Adding the new data to the file
            data.AccountList.Add(model);
            /// At last Writting the modified data to the file
            JsonWrite.Write(data);
        }
        
    }
}

