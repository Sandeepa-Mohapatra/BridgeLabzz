using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Runner
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of the program ");
            Console.WriteLine("Cheak two string are anagram or not(1)");
            Console.WriteLine("Find Prime nos between 1 to 1000(2)");
            Console.WriteLine("Vending Machine(3)");
            Console.WriteLine("Find Day of the week(4)");
            Console.WriteLine("Temprature conversion(5)");
            Console.WriteLine("Mothly Payment(6)");
            Console.WriteLine("SqureRoot using Newton's Law(7)");
            Console.WriteLine("Searching and sorting(8)");
            Console.WriteLine("Binary search for word list(9)");
            Console.WriteLine("Insertion sort of word list(10)");
            Console.WriteLine("Bubble sort of numbers(11)");
            Console.WriteLine("Conversion(12)");
            Console.WriteLine("Binary(13)");
            Console.WriteLine("Merge Sort(14)");
            Console.WriteLine("Number Game(15)");


            int p = int.Parse(Console.ReadLine());
            switch (p)
            {
                case 1:
                    Anagram a = new Anagram();
                    a.ChkAnagram();
                    break;
                case 2:
                    Prime b = new Prime();
                    b.ChkPrime();
                    break;
                case 3:
                    VendingMachine c = new VendingMachine();
                    c.CountNote();
                    break;
                case 4:
                    DayOfWeek d = new DayOfWeek();
                     int m = int.Parse(args[0]);
                     int d1 = int.Parse(args[1]);
                    int y = int.Parse(args[2]);
                    Console.WriteLine(d.FindDay(d1, m, y));
                    break;
                case 5:
                    TempratureConversion e = new TempratureConversion();
                    Console.WriteLine("Enter the temprature");
                    int e1 = int.Parse(Console.ReadLine());
                    e.Conversion(e1);
                    break;
                case 6:
                    MonthlyPayment f = new MonthlyPayment();
                    Console.WriteLine("Enter the Principal loan amount");
                    int p1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the year");
                    int y1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the rate of interest");
                    double r1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(f.FindMPayment(p1, y1, r1));
                    break;
                case 7:
                    SqrtN g = new SqrtN();
                    g.FindSqrt();
                    break;
                case 8:
                    Utility h = new Utility();

                    //Binary search for Integer 

                    Console.WriteLine("Enter the size of the array");
                    int n = int.Parse(Console.ReadLine());
                    int[] h1 = new int[n];
                    Console.WriteLine("Enter the sorted elements in assending order");
                    for (int i = 0; i < n; i++)
                    {
                        h1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Enter the element you want to search");
                    int x = int.Parse(Console.ReadLine());
                    int h2 = h.BinarrySearchInt(h1, x);

                    Console.WriteLine("The element is present in the {0}th place", h2);

                    //Binary search for a string

                    Console.WriteLine("Enter how many elements you want to add");
                    int n1 = int.Parse(Console.ReadLine());
                    String[] h3 = new String[n];
                    Console.WriteLine("Enter Strings");
                    for (int i = 0; i < n; i++)
                    {
                        h3[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the string you want to search");
                    String x1 = Console.ReadLine();
                    int h4 = h.BinarrySearchString(h3, x1);

                    Console.WriteLine("The element is present in the {0}th place", h4);


                    // Insertion sort for Integer

                    Console.WriteLine("Enter the size of the array for sorting");
                    int n2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter  numbers");
                    int[] arr = new int[n2];
                    for (int i = 0; i < n2; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                   int[] arr2= h.InsertionSortInt(arr);
                    Console.WriteLine("Sorted Array Elements :");
                    for (int i = 0; i < n2; i++)
                    {
                        Console.Write(arr2[i]);
                        Console.Write(" ");
                    }
                    Console.WriteLine("\n");


                    //Insertion sort for String

                    Console.WriteLine("Enter how many elements you want to add for sorting");
                    int n3 = int.Parse(Console.ReadLine());
                    String[] h5 = new String[n3];
                    Console.WriteLine("Enter Strings");
                    for (int i = 0; i < n3; i++)
                    {
                        h5[i] = Console.ReadLine();
                    }
                    String[] arr3 = h.InsertionSortString(h5);
                    Console.WriteLine("Sorted Array Elements :");
                    for (int i = 0; i < n2; i++)
                    {
                        Console.Write(arr3[i]);
                        Console.Write(" ");

                    }
                    Console.WriteLine("\n");
      
                    break;
                case 9:
                    BinarySearchWord v = new BinarySearchWord();
                    Console.WriteLine("Enter how many elements you want to add");
                    int n4 = int.Parse(Console.ReadLine());
                    String[] h6 = new String[n4];
                    Console.WriteLine("Enter Strings");
                    for (int i = 0; i < n4; i++)
                    {
                        h6[i] = Console.ReadLine();
                    }
                    Console.WriteLine("Enter the string you want to search");
                    String x3 = Console.ReadLine();
                    int h9 =v.BinarrySearch(h6, x3);

                    Console.WriteLine("The element is present in the {0}th place", h9);
                    break;
                case 10:
                    InsertionSortWord z = new InsertionSortWord();
                    Console.WriteLine("Enter how many elements you want to add for sorting");
                    int n5 = int.Parse(Console.ReadLine());
                    String[] h10 = new String[n5];
                    Console.WriteLine("Enter Strings");
                    for (int i = 0; i < n5; i++)
                    {
                        h10[i] = Console.ReadLine();
                    }
                    String[] arr4 = z.InsertionSort(h10);
                    Console.WriteLine("Sorted Array Elements :");
                    for (int i = 0; i < n5; i++)
                    {
                        Console.Write(arr4[i]);
                        Console.Write(" ");

                    }
                    Console.WriteLine("\n");

                    break;
                case 11:
                    BubbleSort w = new BubbleSort();
                    Console.WriteLine("Enter the size of the array for sorting");
                    int n6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter  numbers");
                    int[] ar = new int[n6];
                    for (int i = 0; i < n6; i++)
                    {
                        ar[i] = int.Parse(Console.ReadLine());
                    }
                    int[] ar1 = w.BubbleSortI(ar);
                    Console.WriteLine("Sorted Array Elements :");
                    for (int i = 0; i < n6; i++)
                    {
                        Console.Write(ar1[i]);
                        Console.Write(" ");
                    }
                    Console.WriteLine("\n");
                    break;
                case 12:
                    Convertion z1 = new Convertion();
                    Console.WriteLine("if you want to convert decimal to binary press 1 and binary to decimal press 0");
                    int de = int.Parse(Console.ReadLine());
                    if (de == 1)
                    {
                        
                        z1.ToBinary();
                    }
                    if(de==0)
                    {
                       z1.ToDecimal();
                    }

                    break;
                case 13:
                    //Convertion s = new Convertion();
                    Console.WriteLine("Enter a decimal no");
                     //int[] ar4= s.ToBinary();
                    int a5 = int.Parse(Console.ReadLine());
                    Binary b1 = new Binary();
                    int ar5=b1.SwapNibbles(a5);
                    Console.WriteLine("After Swapping the no became {0}",ar5);

                    break;
                case 14:
                    MergeSort w1 = new MergeSort();
                    Console.WriteLine("Enter the size of the array");
                    int n7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the elements to the array");
                    int[] iarray = new int[n7];
                    for (int i = 0; i < n7; i++)
                    {
                        iarray[i] = int.Parse(Console.ReadLine());
                    }
                    w1.Sort(iarray);
                   for(int i=0; i<n7;i++)
                    {
                        Console.Write(iarray[i] + " ");
                    }
                    break;
                case 15:
                    NumberGame r2 = new NumberGame();
                    r2.Game();
                    break;
            }
        }
    }
}
