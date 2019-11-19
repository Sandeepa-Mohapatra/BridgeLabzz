// --------------------------------------------------------------------------------------------------------------------
// <copyright file=StartDistribution.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Sandeepa Mohapatra"/>
// --------------------------------------------------------------------------------------------------------------------

namespace ObjectOrientedPrograms.DeckOfCard
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    /// <summary>
    /// Class for Card distribution
    /// </summary>
    class StartDistributing
    {
        /// <summary>
        /// Method for doing all procedure to distribute cards among 4 persons
        /// </summary>
        public void Distributing()
        {
            String[] suit = new String[] {"@","#", "%", "$", };
            String[] rank = new String[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            int n = suit.Length * rank.Length;
            String[] arr=new string[n];
            int count = 0;
            ///Combining both String
            for (int k = 0; k< suit.Length; k++)
            {
                for (int i = 0; i < rank.Length; i++)
                {
                    
                    arr[count]= rank[i] + suit[k];
                    count++;
                }
            }
            Random r = new Random();
           ///Shuffling the cards 
            for (int i = 0; i < arr.Length; i++)
            {
               int ran = r.Next(0,arr.Length);
               string temp = arr[i];
               arr[i] = arr[ran];
               arr[ran] = temp;         
            }
            int l = 0;
            //Distributing among 4 person and displaying
            int count1 = 1;
            while (count1<5)
            {
                Console.WriteLine("[");
                Console.WriteLine();
                for(int i=0;i<3;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        Console.Write(arr[l]+" ");
                        l++;
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("]");
                Console.WriteLine();
                count1++;
            }
        }
    }
}
