using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class FibonacciSeries
    {
        int previousNumber, nextNumber, endNumber, sum;
        public FibonacciSeries(int number)
        {
            this.endNumber = number;
            this.previousNumber = 0;
            this.nextNumber = 1;
            this.sum = 0;
        }
        public void Series()
        {
            for (int i = 1; i <= endNumber; i++)
            {
                Console.Write(previousNumber + " ");
                sum = previousNumber + nextNumber;
                previousNumber = nextNumber;
                nextNumber = sum;
            }     
        }
    }
    
}
