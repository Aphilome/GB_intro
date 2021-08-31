using System;

namespace TemperatureAnalyzer
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input minimum daily temperature: ");
            if (double.TryParse(Console.ReadLine(), out double minTemperature))
            {
                Console.Write("Input maximum daily temperature: ");
                if (double.TryParse(Console.ReadLine(), out double maxTemperature))
                {
                    Console.WriteLine($"Average daily temperature is " +
                                      $"{(minTemperature + maxTemperature) / 2.0:0.00}");
                    return ;
                }
                Console.WriteLine("Can not convert maxTemperature to int");
            }
            Console.WriteLine("Can not convert minTemperature to int");
        }
    }
}