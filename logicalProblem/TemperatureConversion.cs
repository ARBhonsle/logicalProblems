using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProblem
{
    class TemperatureConversion
    {
        readonly Double temperature;
        Double value;
        readonly int option;
        public TemperatureConversion(int option, double degree)
        {
            this.option = option;
            this.temperature = degree;
        }
        public void Convert()
        {
            switch (option)
            {
                case 1:
                    value = (temperature * 1.8) + 32;
                    Console.WriteLine("Celsius: " + temperature);
                    Console.WriteLine("Farenheit: " + value);
                    break;
                case 2:
                    value = (temperature - 32)  / 1.8;
                    Console.WriteLine("Farenheit: " + temperature);
                    Console.WriteLine("Celsius: " + value);
                    break;
            }
        }
    }
}
