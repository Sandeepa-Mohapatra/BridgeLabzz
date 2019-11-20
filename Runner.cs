
namespace DesignPtternPrograms
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Runner
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter which program you want to see");
            Console.WriteLine("Singleton pattern(1)");
            int n = int.Parse(Console.ReadLine());
            switch(n)
            {
                case 1:
                    SingleTon.SingletonMain a = new SingleTon.SingletonMain();
                    a.Method();
                    break;
            }
        }
    }
}
