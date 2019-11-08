using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class CashCounter
    {
        
        public void Counter()
        {
            Utility u = new Utility();
            Console.WriteLine("Enter 1 if you want to Deposite ya withdrow money");
            Console.WriteLine("Enter 2 if your work is done");
            Console.WriteLine("Enter 3 to Exit");
            int n = int.Parse(Console.ReadLine());
            int c = 1;
            int x = 1;
            while (x>0)
            {
                Console.WriteLine("Enter 1 if you want to Deposite ya withdrow money");

                if (n == 1)
                {

                    u.Enqueue(1);
                    c++;
                    Console.WriteLine("Enter 2 if your work is done");
                    Console.WriteLine("Enter 3 to know the no of person in the queue");
                    
                    n = int.Parse(Console.ReadLine());
                    if (n == 2)
                    {
                        c = c - 1;
                        u.Dequeue();
                        x--;
                        Console.WriteLine("Thank You.....Come Again");
                        break;
                    }
                    else if(n==3)
                    {
                        Console.WriteLine("The no of person is",c);
                        break;
                    }
                    
                }
                
            }
       
        }

    }
}
