/*************************************Utility*********************************************/
/*Read an Arithmetic Expression .Write a Stack Class to push open parenthesis “(“ and pop closed
parenthesis “)”. At the End of the Expression if the Stack is Empty then the Arithmetic Expression
is Balanced.
<<Author : Sandeepa Mohapatra>>
 */
/**********************************************************************************************/



using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class BalancingParanthesis
    {
        public void ChkBalance(String str)
        {
            Utility u = new Utility();

            char[] item = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {

                if (item[i] == '(')
                {
                    
                    u.Push('(');
                }
                else if (item[i] == ')')
                {
                    
                    u.Pop();
                }
            }
            if (u.IsEmpty())
            {

                Console.WriteLine("balanced");
            }
            else
            {
                Console.WriteLine("not balanced");
            }
        }
    }
}
