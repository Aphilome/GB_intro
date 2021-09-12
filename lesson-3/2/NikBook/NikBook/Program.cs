using System;
using System.Text;

namespace NikBook
{
    class Program
    {
        static void Main()
        {
            string[,] nikBook =
            {
                {"Андрей", "@andreyp_gb"},
                {"Даниил", "@dmonin"},
                {"Екатерина", "@aphilome"},
                {"Кристина", "@kristina_help_gb"},
                {"Сергей", "@sdramare"},
            };

            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            
            Console.Write("Введите имя героя обьединения GeekBrains: ");
            string name = Console.ReadLine()?.ToLower();
            for (byte i = 0; i < nikBook.GetLength(0); i++)
            {
                if (name == nikBook[i, 0].ToLower())
                {
                    Console.WriteLine($"Имя пользователя {nikBook[i, 0]} в telegram: {nikBook[i, 1]}");
                    return ;
                }
            }
            Console.WriteLine("Введенное имя не найдено. Попробуйте повторить Ваш запрос");
        }
    }
}