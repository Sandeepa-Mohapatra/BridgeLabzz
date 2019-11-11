using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Calender
    {
        
        public void PrintCalender()
        {
            Utility u = new Utility();
            Console.WriteLine("Enter month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year= int.Parse(Console.ReadLine());
            //  name of months 
            String[] months = {"","January", "February", "March","April", "May", "June","July", "August", "September","October", "November", "December"};

            // days in month 
            int[] days = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            
            

            // print calendar header
            Console.WriteLine("   " + months[month] + " " + year);
            Console.WriteLine(" S  M Tu  W Th  F  S");

            // starting day
            int d = u.FindDay(month, 1, year);

            // print the calendar
            for (int i = 0; i < d; i++)
            {
                Console.Write("   ");
            }
            for (int i = 1; i <= days[month]; i++)
            {
                Console.Write(i+" ");
                if (((i + d) % 7 == 0) || (i == days[month]))
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
    

