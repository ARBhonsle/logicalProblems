using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class MonthlyPayment
    {
        int principleAmount, yearDuration;
        Double interestRate,value;
        public MonthlyPayment(int number,int year,Double rate)
        {
            this.principleAmount = number;
            this.yearDuration = year * 12;
            this.interestRate = rate / (12 * 100);
        }
        public void MonthlyCalc()
        {
            value = (principleAmount * interestRate) / (1 - Math.Pow((1 + interestRate), -yearDuration));
            Console.WriteLine("Monthly Payment: " + value);
        }
    }
}
