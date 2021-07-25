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
                Console.WriteLine("7.Vending Machine 8.Day of week 9.Temperature Conversion");
                choice = Convert.ToInt32(Console.ReadLine());                
                if (choice == 8)
                {
                    Console.WriteLine("m-d-y format of input");
                    Console.WriteLine("Month input:");
                }
                else if (choice == 9)
                {
                    Console.WriteLine("Convert 1.Celsius to Farenheit 2.Farenheit to Celsius");
                }
                else
                {
                    Console.WriteLine("Give Value/Number: ");
                }
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
                    case 7:
                        VendingMachine vendingMachine = new VendingMachine(number);
                        vendingMachine.MoneyNotes();
                        break;
                    case 8:                        
                        Console.WriteLine("Day input:");
                        int number1= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Year input:");
                        int number2= Convert.ToInt32(Console.ReadLine());
                        DayOfWeek dayOfWeek = new DayOfWeek(number, number1, number2);
                        dayOfWeek.DayCalc();
                        break;
                    case 9:
                        if(number == 1 || number == 2)
                        {
                            Console.WriteLine("Give Degree ");
                            Double degree = Convert.ToInt32(Console.ReadLine());
                            TemperatureConversion temperatureConversion = new TemperatureConversion(number, degree);
                            temperatureConversion.Convert();
                        }
                        else
                        {
                            Console.WriteLine("Wrong Input");
                        }                        
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
