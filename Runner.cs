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
    using System.ComponentModel.DataAnnotations;
    using System.Reflection;
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
            Console.WriteLine("Observer Pattern(5)");
            Console.WriteLine("Command Pattern(6)");
            Console.WriteLine("Strategy Pattern(7)");
            Console.WriteLine("Dependency Injection(8)");
            Console.WriteLine("Reflection(9)");
            Console.WriteLine("Annotation(10)");
            int n = int.Parse(Console.ReadLine());
            switch (n)
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
                case 5:
                    ObserverPattern.ConcreteSubject s = new ObserverPattern.ConcreteSubject();
                    ObserverPattern.IObserver s2 = new ObserverPattern.ConcreteObserver(s);
                    s.Attach(s2);
                    String s3 = "one";
                    s.SetState(s3);
                    ObserverPattern.IObserver s4 = new ObserverPattern.ConcreteObserver(s);
                    s.Attach(s4);
                    String s5 = "two";
                    s.SetState(s5);
                    ObserverPattern.IObserver s6 = new ObserverPattern.ConcreteObserver(s);
                    s.Attach(s4);
                    String s7 = "three";
                    s.SetState(s7);
                    break;
                case 6:
                    Command.Client e = new Command.Client();
                    e.RunCommand();
                    break;
                case 7:
                    Strategy.Client f = new Strategy.Client();
                    Console.WriteLine("This is the normal way ");
                    f.SetStrategy(new Strategy.ConcretStrategy1());
                    f.Display();
                    Console.WriteLine();
                    Console.WriteLine("This is using Math.Pow");
                    f.SetStrategy(new Strategy.ConcretStrategy2());
                    f.Display();
                    break;
                case 8:
                    Dependency_Injection.DependencyMain g = new Dependency_Injection.DependencyMain();
                    g.Choice();
                    break;
                case 9:
                    Reflection.ReflectionP h = new Reflection.ReflectionP();
                    h.Show();
                    break;
                case 10:
                    Annotation j = new Annotation();
                    j.Name="San";
                    var context = new ValidationContext(j, null, null);
                    bool IsValid = Validator.TryValidateObject(j, context, null, true);
                    Console.Write("Your entered name is : ");
                    if (IsValid)
                    {
                        Console.WriteLine("valid");
                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                    
                    j.Multiply(10, 49);
                    int result=j.Multiply(new List<int>(){ 10,20,40,50});
                    Console.WriteLine("Total multiplication of all numbers in the list is: {0}",result);
                    break;
            }
        }
    }
}
