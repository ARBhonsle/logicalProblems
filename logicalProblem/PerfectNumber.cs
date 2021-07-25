using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class PerfectNumber
    {
        int perfectNumber,sum;
        public PerfectNumber(int number)
        {
            this.perfectNumber = number;
            this.sum = 0;
        }

        public void Compute()
        {
            for(int i = 1; i < perfectNumber; i++)
            {
                if (perfectNumber % i == 0)
                {
                    Console.Write(i + " ");
                    sum += i;
                    if (i < perfectNumber)
                    {
                        Console.Write("+");
                    }
                }                
            }
            Console.WriteLine("="+sum);
            if (sum.Equals(perfectNumber))
            {
                Console.WriteLine("Given number is perfect number");
            }
            else
            {
                Console.WriteLine("Given number is not perfect number");
            }
        }
    }
}
