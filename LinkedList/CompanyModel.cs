// --------------------------------------------------------------------------------------------------------------------
// <copyright file=CompanyModels.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.LinkedList
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class CompanyModel
    {
        private string name;
        private int share;
        private int price;
        //Parameterize constructor
        public CompanyModel(string name, int share, int price)
        {
            this.name = name;
            this.share = share;
            this.price = price;
        }

        public String Companyname
        {
            
            get { return this.name; }
            set { this.name = value; }
        }
        public int Numberofshare
        {
            
            get { return this.share; }
            set { this.share = value; }
        }
        public int Priceofshare
        {
            
            get { return this.price; }
            set { this.price = value; }
        }

        public static void CreateObject(String name,int share,int price)
        {
            CompanyModel c = new CompanyModel(name,  share,  price);
            /// Read the json file
            var data = JsonReadfile.Read();
            /// Adding the new data to the file
            data.File.Add(c);
            /// At last Writting the modified data to the file
            JsonWrite.Write(data);
        }
    }
}
