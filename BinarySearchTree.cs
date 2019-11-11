
/*************************************BST*********************************************/
/*Number of Binary Search Tree
<<Author : Sandeepa Mohapatra>>
 */
/**********************************************************************************************/


using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class BinarySearchTree
    {
        
            
            public  void BinaryTree()
            {
               
                    int num = 0;
                    bool iterate = true;
                    while (iterate)
                    {
                        Console.WriteLine("Enter the Number of Elements");
                        string element = Console.ReadLine();
                        if (Utility.IsNum(element) == false)
                        {
                            Console.WriteLine("Invalid Input");
                            continue;
                        }
                        num = Convert.ToInt32(element);
                        if (num < 0)
                        {
                            Console.WriteLine("Element Should be Greater than 0");
                            continue;
                        }
                        iterate = false;

                    }

                    int numBinaryTrees = Utility.CountBinaryTree(num);
                    Console.WriteLine("Number of posslible of Binary Trees are = " + numBinaryTrees);
                
                
            }
    }
}
