using System;

namespace MonthPrinter
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input number of the current month: ");

            if (int.TryParse(Console.ReadLine(), out int currentMonth))
            {
                if (currentMonth > 0 && currentMonth < 13)
                {
                    DateTime date = new DateTime(2000, currentMonth, 01);
                    Console.WriteLine($"Current month is: " +
                                      $"{date.ToString("MMMM")}");
                    return ;
                }
            }
            Console.WriteLine("Error");
        }
    }
}