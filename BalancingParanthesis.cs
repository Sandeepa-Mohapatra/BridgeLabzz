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
                    //System.out.println("m");
                    u.Push('(');
                }
                else if (item[i] == ')')
                {
                    //System.out.println("m");
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
