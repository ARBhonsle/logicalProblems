using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class DayOfWeek
    {
        readonly int month, day, year;
        int y0, x, m0, d0;
        public DayOfWeek(int number,int number1,int number2)
        {
            this.month = number;
            this.day = number1;
            this.year = number2;
        }
        public void DayCalc()
        {
            y0 = year - (14 - month) / 12;
            x = y0 * (1 + 1 / 4 - 1 / 100 + 1 / 400);
            m0 = month+12*((14-month)/12)-2;
            d0 = (day + x + 31 * m0 / 12) % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
