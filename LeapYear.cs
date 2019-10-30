using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class LeapYear
    {
        public void ChkLeapYear()
        {
            Console.WriteLine("Enter the year to cheak");
            int yr = int.Parse(Console.ReadLine());
            if (yr >= 1000 && yr <= 9999)
            {
                if (yr % 400 == 0 || yr % 4 == 0 && yr % 100 != 0)
                {

                    Console.WriteLine("its  a leap yr");
                }
                else
                {
                    Console.WriteLine("its not a leap yr");
                }

            }
            else
            {
                Console.WriteLine("invalid entry");
            }


        }

    }
}
