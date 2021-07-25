using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class PrimeNumber
    {
        int primeNumber,counter;
        public PrimeNumber(int number)
        {
            this.primeNumber = number;
            this.counter = 0;
        }
        public void Check()
        {
            for(int i = 2; i <= primeNumber; i++)
            {
                if (primeNumber % i == 0)
                {
                    counter++;
                }
            }
            if (counter.Equals(1))
            {
                Console.WriteLine("Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime Number");
            }
        }
    }
}
