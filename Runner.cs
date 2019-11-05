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
            Console.WriteLine("Find the Factor of a no(7)");
            Console.WriteLine("Generate Distinct Cupon no.(8)");
            Console.WriteLine("Gambler Game(9)");
            Console.WriteLine("Triple Sum(10)");
            Console.WriteLine("Find Distance(11)");
            Console.WriteLine("Stop Watch(12)");
            Console.WriteLine("Qudratic(13)");
            Console.WriteLine("Calculate WindChill(14)");


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
                    Array2D a = new Array2D();
                    //Calling the methods to generate 2D array by taking user input
                    a.ArrayInt(r, c);
                    a.ArrayDouble(r, c);
                    a.ArrayBoolean(r, c);
                    break;

                case 2:
                    ReplaceStr b = new ReplaceStr();
                    //Calling method to replace the string by the user given string 
                    b.ReplaceS();
                    break;
                case 3:
                    FlipCoin d = new FlipCoin();
                    //Calling method to flip the coin and calculate the percentage
                    d.CoinFlip();
                    break;
                case 4:
                    LeapYear e = new LeapYear();
                    //Calling method to cheak whether the year is a leap year or not
                    e.ChkLeapYear(); 
                    break;
                case 5:
                    PowerOfTwo f = new PowerOfTwo();
                    //Calling method to calculate the power of 2 from 0 to n
                    f.Powerof2();
                    break;
                case 6:
                    Harmonic h = new Harmonic();
                    //Calling method to calculate the nth harmonic no
                    h.ChkHarmonic();
                    break;
                case 7:
                    Factors g = new Factors();
                    //Calling method to find the factors of a no
                    g.FindFactors();
                    break;
                case 8:
                    CuponNum k = new CuponNum();
                    //Calling method to generate the cupon nos
                    k.Couponno();
                    break;
                case 9:
                    Gambler l = new Gambler();
                    //Calling method to play Gambling Game
                    l.GamblerG();
                    break;
                case 10:
                    TripleSum m = new TripleSum();
                    //Calling method to find the sequence of three nos which sum is equals to 0
                    m.ThreeSum();
                    break;
                case 11:
                    Distance n = new Distance();
                    //calling method to calculate the distance between two points
                    n.FindDistance();
                    break;
                case 12:
                    StopWatch o = new StopWatch();
                    //Start the watch
                    Console.WriteLine("Enter 1 to start");
                    int t = int.Parse(Console.ReadLine());
                    if (t == 1)
                    {
                        o.Start();
                    }


                    //Stop and Calculate the Elapsed time
                    Console.WriteLine("Enter 0 to stop");
                    int t1= int.Parse(Console.ReadLine());
                    if (t1 == 0)
                    {
                        o.Stop();
                    }
                  
                    Console.WriteLine();
                    break;
                case 13:
                    Quadratic q = new Quadratic();
                    //Calling Find method to find  roots
                    q.Find();
                    break;

                case 14:
                    int x = int.Parse(args[0]);
                    int y= int.Parse(args[0]);
                    WindChill s = new WindChill();
                    //calling method to calculate windchill
                    s.FindWindChill(x,y);
                    break;
                



                
            }
                
            




        }
    }
}
