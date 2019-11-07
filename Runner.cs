/******************************************************Runner***********************************************************/
/*It contains the main method from where the execution will start. In this Main() all Data structure Programs are present
<<Author : Sandeepa Mohapatra>>
 */
/***********************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class Runner
    {
        static void Main(string[] args)
        {
            //User will choose the program  here from the given options
            Console.WriteLine("Enter the no of the program which you want to run from the given programs");
            Console.WriteLine("UnSorted List(1)");
            Console.WriteLine("Ordered List(2)");


            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    //The object of the class is created
                    UnOrderedList a = new UnOrderedList();
                    //This will call the method to perform the operation 
                    a.Operation();
                    break;
                case 2:
                    //The object of the class is created
                    OrderedList b = new OrderedList();
                    //This will call the method to perform the operation 
                    b.OperationOL();
                    break;
            }
        }
    }
}
