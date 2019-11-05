using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Gambler
    {
        public void GamblerG()
        {

            Console.WriteLine("Enter the stak");
            int stake = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the goal");
            int goal = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of trials");
            int trials = int.Parse(Console.ReadLine());
            int bets = 0;
            int wins = 0;
            Random r = new Random();
            for (int t = 0; t < trials; t++)
            {


                int cash = stake;
                while (cash > 0 && cash < goal)
                {
                    bets++;
                    if (r.Next() < 0.5) cash++;
                    else cash--;
                }
                if (cash == goal) wins++;
            }

            // print results
            Console.WriteLine(wins + " wins of " + trials);
            Console.WriteLine("Percent of games won = " + 100.0 * wins / trials);
            Console.WriteLine("Avg # bet= " + 1.0 * bets / trials);
        }
    } 
}
