// --------------------------------------------------------------------------------------------------------------------
// <copyright file=DelegateP.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.Delegates
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class to implement delegates
    /// </summary>
    class DelegateP
    {
        /// <summary>
        /// Declaring Delegates
        /// </summary>
        /// <param name="a"></param>
        public delegate void Factors(int a);
        /// <summary>
        /// Method for finding the fectors of a no
        /// </summary>
        /// <param name="n"></param>
        public void FindFactors(int n)
        {
            
            Console.Write("the Factors are : ");
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {

                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.WriteLine(n);
        }
        /// <summary>
        /// Method for creating delegate object and call the  method to find the factors of a no 
        /// </summary>
        /// <param name="a"></param>
        public void Method(DelegateP a)
        {
            ///creating delegate object
            Factors obj = new Factors(a.FindFactors);
            Console.WriteLine("Enter a no");
            int n = int.Parse(Console.ReadLine());
            obj(n);

        }
    }
}
