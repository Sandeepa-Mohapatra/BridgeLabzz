// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Runner.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------


namespace ObjectOrientedPrograms
{
    using System;

    class Runner
    {
        /// <summary>
        ///Execution will be started from this method
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            ///User will choose the program  here from the given options
            Console.WriteLine("Enter the no of the program which you want to run from the given programs");
            Console.WriteLine("Inventory Data Management(1)");
            Console.WriteLine("Replace Strings(2)");
            Console.WriteLine("Stock Report(3)");
            Console.WriteLine("Inventory Manegement System(4)");
            Console.WriteLine("Commercial data processing(5)");
            Console.WriteLine("LinkedList(6)");
            Console.WriteLine("Deck Of Cards(7)");
            Console.WriteLine("Address Book(8)");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    ///Object is created and calling the method to perform the total operation
                    Inventory_Management.DisplayData a = new Inventory_Management.DisplayData();
                    a.Display();
                    break;
                case 2:
                    RegularExpression.RegularExp b = new RegularExpression.RegularExp();
                    b.RegexExp();
                    break;
                case 3:
                    StockReport.StockDisplay c = new StockReport.StockDisplay();
                    c.Display();
                    break;
                case 4:
                    InventoryManagementSystem.InventoryManager d = new InventoryManagementSystem.InventoryManager();
                    d.Operation();
                    break;
                case 5:
                    CommercialDataProcessing.UserInputOptions e = new CommercialDataProcessing.UserInputOptions();
                    e.GetInputs();
                    break;
                case 6:
                    LinkedList.UserMaintainance f = new LinkedList.UserMaintainance();
                    f.MaintainDetails();
                    break;
                case 7:
                    DeckOfCard.StartDistributing g = new DeckOfCard.StartDistributing();
                    g.Distributing();
                    break;
                case 8:
                    AddressBook.UserAddress h = new AddressBook.UserAddress();
                    h.Operation();
                    break;
            }

        }

    }
}
