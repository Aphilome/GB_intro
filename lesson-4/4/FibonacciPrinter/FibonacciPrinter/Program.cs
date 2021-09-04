using System;

namespace FibonacciPrinter
{
    class Program
    {
        static ulong GetRecourseFibonacci(ulong index)
        {
            switch (index)
            {
                case 0:
                    return 0;
                case 1:
                case 2:
                    return 1;
                default:
                    return GetRecourseFibonacci(index - 1)
                           + GetRecourseFibonacci(index - 2);
            }
        }
        
        static void Main()
        {
            Console.Write($"Input Fibonacci index: ");
            string input = Console.ReadLine();
            if (!ulong.TryParse(input, out ulong index))
            {
                Console.WriteLine("Error getting index");
                return ;
            }
            Console.WriteLine($"Fibonacci ({index}) = {GetRecourseFibonacci(index)}");
        }
    }
}