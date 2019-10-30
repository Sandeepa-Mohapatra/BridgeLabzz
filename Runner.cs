using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp2;

namespace Functional
{
    class Runner
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the no of the program which you want to run from the given programs");
            Console.WriteLine("2d Array(1)");
            Console.WriteLine("Replace the string(2)");
            Console.WriteLine("Flip a Coin(3)");
            Console.WriteLine("Cheak wheather the year is leap year or not(4)");
            Console.WriteLine("Power of 2(5)");
            Console.WriteLine("Find nth Harmonic no(6)");
            Console.WriteLine("Find the Factor of a no");


            int p = int.Parse(Console.ReadLine());
            switch(p)
            {
                case 1:
                    Console.WriteLine("Enter the row");
                    int r;
                    r = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the coulumn");
                    int c;
                    c = int.Parse(Console.ReadLine());
                    //Calling the methods
                    Array2D a = new Array2D();
                    a.ArrayInt(r, c);
                    a.ArrayDouble(r, c);
                    a.ArrayBoolean(r, c);
                    break;

                case 2:
                    ReplaceStr b = new ReplaceStr();
                    b.ReplaceS();
                    break;
                case 3:
                    FlipCoin d = new FlipCoin();
                    d.CoinFlip();
                    break;
                case 4:
                    LeapYear e = new LeapYear();
                    e.ChkLeapYear(); 
                    break;
                case 5:
                    PowerOfTwo f = new PowerOfTwo();
                    f.Powerof2();
                    break;
                case 6:
                    Harmonic h = new Harmonic();
                    h.ChkHarmonic();
                    break;
                case 7:
                    Factors g = new Factors();
                    g.FindFactors();
                    break;



            }
                
            




        }
    }
}
