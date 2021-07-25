using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class ReverseNumber
    {
        int reverseNumber, sum;
        public ReverseNumber(int number)
        {
            this.reverseNumber = number;
            this.sum = 0;
        }
        public void Reverse()
        {
            while (reverseNumber > 0)
            {
                sum = sum * 10 + reverseNumber % 10;
                reverseNumber /= 10;
            }
            Console.WriteLine("Reverse Number is " + sum);
        }
    }
}
