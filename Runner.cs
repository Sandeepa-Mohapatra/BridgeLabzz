// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Runner.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPtternPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class which contain Main method
    /// </summary>
    class Runner
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter which program you want to see");
            Console.WriteLine("Singleton pattern(1)");
            Console.WriteLine("Factory Pattern(2)");
            Console.WriteLine("Adaptor Pattern(3)");
            Console.WriteLine("Prototype Pattern(4)");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    SingleTon.SingletonMain a = new SingleTon.SingletonMain();
                    a.Method();
                    break;
                case 2:
                    Factory.StuffFactory b = new Factory.CreatStuffFactory();
                    Factory.IFactory Book = b.GetFactory("Book");
                    Book.Count(100);
                    Factory.IFactory Pen = b.GetFactory("Pen");
                    Pen.Count(50);
                    break;
                case 3:
                    Adapter.ITarget c = new Adapter.AdapterC();
                    Adapter.Client d = new Adapter.Client(c);
                    d.ShowName();
                    break;
                case 4:
                    Prototype.Developer dev = new Prototype.Developer();
                    dev.Name = "Sanna";
                    dev.Designation = "Team Leader";
                    Prototype.Developer devCopy = (Prototype.Developer)dev.Clone();
                    devCopy.Name = "San";
                    Console.WriteLine(dev.GetDetails());
                    Console.WriteLine(devCopy.GetDetails());

                    Prototype.Tester tst = new Prototype.Tester();
                    tst.Name = "Maan";
                    tst.Designation = "Network Test Engineer";
                    Prototype.Tester tstCopy = (Prototype.Tester)tst.Clone();
                    tstCopy.Name = "Naina";
                    Console.WriteLine(tst.GetDetails());
                    Console.WriteLine(tstCopy.GetDetails());
                    break;
            }
        }
    }
}
