using System;

namespace FizzBuzz_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i += 2)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
                if ((i + 1) % 3 == 0 && (i + 1) % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if ((i + 1) % 3 == 0)
                    Console.WriteLine("Fizz");
                else if ((i + 1) % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine((i + 1));
            }
        }
    }
}