using System;

namespace logicalProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems");
            string nextProblem;
            int choice, number;
            nextProblem = "y";
            while (nextProblem.Equals("y"))
            {
                Console.WriteLine("1.Fibonacci Series 2.Perfect Number 3.Prime Number 4.Reverse Number 5.Coupon Numbers 6.StopWatch");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Give Value/Number: ");
                number = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FibonacciSeries fibonacciSeries = new FibonacciSeries(number);
                        fibonacciSeries.Series();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber(number);
                        perfectNumber.Compute();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber(number);
                        primeNumber.Check();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber(number);
                        reverseNumber.Reverse();
                        break;
                    case 5:
                        CouponNumbers couponNumbers = new CouponNumbers(number);
                        couponNumbers.DistinctCoupon();
                        break;
                    case 6:
                        StopWatch watch = new StopWatch(number);
                        watch.TimeElapsed();
                        break;
                    default: 
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue? y or n");
                nextProblem = Console.ReadLine();
            }
        }
    }
}
