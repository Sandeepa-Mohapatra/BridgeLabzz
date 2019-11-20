// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WrioteToFile.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra">
// --------------------------------------------------------------------------------------------------------------------
      
namespace ObjectOrientedPrograms.CommercialDataProcessing
{
        using System;
        using System.Collections.Generic;
        using System.Text;
        using Newtonsoft.Json;

    /// <summary>
    /// class for write the contents into file
    /// </summary>
    class WriteToFile
    {        
            /// <summary>
            /// Writes to file.
            /// </summary>
            /// <param name="newAccount">The inventory types.</param>
            public static void WriteDataToFile(NewAccount newAccount)
            {
                //// Json file path
                string path = (@"C:\Users\COMPUTER\source\repos\ConsoleApp5\ConsoleApp5\CommercialDataProcessing\AccountStockFile.json");
                ////Converting NewAccount Object to Json String
                string jsonAdddressBook = JsonConvert.SerializeObject(newAccount);
                ////Wrinting Json String to file.
                System.IO.File.WriteAllText(path, jsonAdddressBook);
            }
        }
    }


