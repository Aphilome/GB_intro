using System;

namespace SumPrinter
{
    class Program
    {
        static long Sum(string input)
        {
            long res = 0;
            string[] nums = input.Split(' ');
            foreach (var i in nums)
            {
                if (long.TryParse(i, out long tmpRes))
                    res += tmpRes;
            }
            return res;
        }
        
        static void Main()
        {
            Console.Write("Input numbers separated by a spaces: ");
            string input = Console.ReadLine();
            Console.WriteLine($"Sum = {Sum(input)}");
        }
    }
}
