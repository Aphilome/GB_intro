using System;
using System.Text;

namespace RainingWinterPrinter
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Input number of the current month: ");
            if (!int.TryParse(Console.ReadLine(), out int currentMonth))
            {
                Console.WriteLine("Error");
                return;
            }
            if (!(currentMonth > 0 && currentMonth < 13))
            {
                Console.WriteLine("Error");
                return;
            }
            Console.Write("Input minimum daily temperature: ");
            if (!double.TryParse(Console.ReadLine(), out double minTemperature))
            {
                Console.WriteLine("Can not convert minTemperature to double");
                return ;
            }
            Console.Write("Input maximum daily temperature: ");
            if (!double.TryParse(Console.ReadLine(), out double maxTemperature))
            {
                Console.WriteLine("Can not convert minTemperature to double");
                return ;
            }
            DateTime date = new DateTime(2000, currentMonth, 01);
            Console.WriteLine($"Current month is: " +
                              $"{date.ToString("MMMM")}");
            double avrDTemp = (minTemperature + maxTemperature) / 2.0;
            Console.WriteLine($"Average daily temperature is " +
                              $"{avrDTemp:0.00}");
            if ((currentMonth == 12 || currentMonth == 1 || currentMonth == 2)
                && avrDTemp > 0)
                Console.WriteLine("Дождливая зима");
        }
    }
}