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
                Console.WriteLine("1.Fibonacci Series");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Give number: ");
                        number = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries fibonacciSeries = new FibonacciSeries(number);
                        fibonacciSeries.Series();
                        break;
                    default: 
                        Console.WriteLine("Wrong Input");
                        break;
                }
                Console.WriteLine("Do you want to continue? y or n");
                nextProblem = Console.ReadLine();
            }
        }
    }
}
