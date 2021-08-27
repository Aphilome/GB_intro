using System;
using System.Text;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            string name;
            do
            {
                Console.Write("Введите свое имя: "); 
                name = Console.ReadLine();
            } while (name == "");
            Console.WriteLine($"Привет, " + name + ", сегодня " + DateTime.Now.ToString("dd.MM.yyyy"));
        }
    }
}

