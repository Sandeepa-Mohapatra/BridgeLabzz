using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Runner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of the program ");
            Console.WriteLine("Cheak two string are anagram or not(1)");
            Console.WriteLine("Find Prime nos between 1 to 1000(2)");
            Console.WriteLine("Vending Machine(3)");
            Console.WriteLine("Find Day of the week(4)");
            Console.WriteLine("Temprature conversion(5)");
            Console.WriteLine("Mothly Payment(6)");


            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    Anagram a = new Anagram();
                    a.ChkAnagram();
                    break;
                case 2:
                    Prime b = new Prime();
                    b.ChkPrime();
                    break;
                case 3:
                    VendingMachine c = new VendingMachine();
                    c.CountNote();
                    break;
                case 4:
                    DayOfWeek d = new DayOfWeek();
                     int m = int.Parse(args[0]);
                     int d1 = int.Parse(args[1]);
                    int y = int.Parse(args[2]);
                    Console.WriteLine(d.FindDay(d1, m, y));
                    break;
                case 5:
                    TempratureConversion e = new TempratureConversion();
                    Console.WriteLine("Enter the temprature");
                    int e1 = int.Parse(Console.ReadLine());
                    e.Conversion(e1);
                    break;
                case 6:
                    MonthlyPayment f = new MonthlyPayment();
                    Console.WriteLine("Enter the Principal loan amount");
                    int p1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the year");
                    int y1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the rate of interest");
                    double r1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(f.FindMPayment(p1, y1, r1));
                    break;
            }
        }
    }
}
