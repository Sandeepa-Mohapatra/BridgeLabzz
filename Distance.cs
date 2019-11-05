using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Distance
    {
        public void FindDistance()
        {
            double x, y, z, a;
            Console.WriteLine("Enter first point");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd point");
            y = double.Parse(Console.ReadLine());
            a = (x * x + y * y);
            z = Math.Sqrt(a);
            Console.WriteLine("Distance=" + z);

        }
    }
}
