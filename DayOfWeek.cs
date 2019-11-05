using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class DayOfWeek
    {
        public string FindDay(int d,int m,int y)
        {
            if (d <= 31 && m <= 12)
            {
                double y0 = y - ((14 - m) / 12);
                double x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
                double m0 = m + 12 * ((14 - m) / 12) - 2;
                double d0 = (d + x + 31 * m0 / 12) % 7;
                int s = (int)Math.Round(d0) - 1;

                switch (s)
                {
                    case 0:
                        return "Sun";
                    case 1:
                        return "Mon";
                    case 2:
                        return "Tue";
                    case 3:
                        return "wed";
                    case 4:
                        return "Thurs";
                    case 5:
                        return "fri";
                    case 6:
                        return "sat";
                }
            }
            return "";

        }

    }
}
