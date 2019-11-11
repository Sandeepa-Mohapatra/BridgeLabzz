﻿/******************************************************Runner***********************************************************/
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

            Console.WriteLine("Balancing Pranthesis(3)");
            Console.WriteLine("Cash Counter(4)");
            Console.WriteLine("Palindrom Checking(5)");
            Console.WriteLine("Hashing Function to search a number(6)");
            Console.WriteLine("Calender(7)");



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
                case 3:
                    //The object of the class is created
                    Console.WriteLine("Enter the Expression");
                    String str = Console.ReadLine();
                    BalancingParanthesis d = new BalancingParanthesis();
                    //This will call the method to perform the operation 
                    d.ChkBalance(str);
                    break;
                case 4:
                    //The object of the class is created
                    CashCounter e = new CashCounter();
                    //This will call the method to perform the operation 
                    e.Counter();
                    break;
                case 5:
                    //The object of the class is created
                    PalindromChk f = new PalindromChk();
                    //This will call the method to perform the operation 
                    f.Check();
                    break;
                case 6:
                    Hashing obj = new Hashing();
                    obj.Hash(77);
                    obj.Hash(44);
                    obj.Hash(55);
                    obj.Hash(26);
                    obj.Hash(93);
                    obj.Hash(17);
                    obj.Hash(31);
                    obj.Hash(20);
                    obj.Hash(54);
                    obj.Display();

                    break;
                case 7:
                    Calender g = new Calender();
                    g.PrintCalender();
                    break;
                case 8:
                    Prime2DArray h = new Prime2DArray();
                    Utility u = new Utility();
                    int[,] ar=h.PrintArray();
                    u.Display(ar);
                    break;
                case 9:
                    BinarySearchTree j = new BinarySearchTree();
                    j.BinaryTree();
                    break;

            }
        }
    }
}
