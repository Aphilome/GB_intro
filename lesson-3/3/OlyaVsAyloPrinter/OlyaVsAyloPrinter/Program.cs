using System;
using System.Text;

namespace OlyaVsAyloPrinter
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.Write("Введите строку: ");
            string input = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("В строке отсутствуют данные. Введите строку: ");
                input = Console.ReadLine();
            }
            var sb = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
                sb.Append(input[i]);
            Console.WriteLine($"Лексическая реверсия строки: {sb}");
        }
    }
}