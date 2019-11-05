using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MonthlyPayment
    {
        public float FindMPayment(int p,int y,double r)
        {
            int n = 12 * y;
            double a = 1 + (r / (12 * 100));
            double b = Math.Pow(a, (-n));
            float payment = (float)((p * a) / 1 - b);
            return payment;
        }
    }
}
