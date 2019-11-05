using System;
using System.Collections.Generic;
using System.Text;

namespace Functional
{
    class Quadratic
    {
        public void Find()
        {

            int a, b, c;
            double r1, r2, delta;
            double s;
            Console.WriteLine("Enter the values");

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            delta = b * b - 4 * a * c;
            s = Math.Sqrt(delta);
            r1 = (-b + s) / 2 * a;
            r2 = (-b - s) / 2 * a;
            Console.WriteLine("Equation is :" + a + "x*x + " + b + "x + " + c);
            Console.WriteLine("root of x is " + r1 + "and " + r2);
        }
    }
}
