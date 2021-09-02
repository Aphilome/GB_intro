using System;

namespace ParityPrinter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input an integer");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                    Console.WriteLine("Number is even");
                else
                    Console.WriteLine("Number is odd");
                return ;
            }
            Console.WriteLine("Error");
        }
    }
}
