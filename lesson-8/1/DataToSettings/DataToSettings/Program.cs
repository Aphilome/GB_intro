using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataToSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine(Properties.Settings.Default.Hello);
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Имя пользователя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Имя пользователя: {Properties.Settings.Default.UserName}");
            }

            if (Properties.Settings.Default.UserAge <= 0)
            {
                Console.Write("Возраст пользователя: ");
                var input = Console.ReadLine();
                if (!byte.TryParse(input, out byte age))
                {
                    Console.WriteLine("Ошибка парсинга");
                    return;
                }
                Properties.Settings.Default.UserAge = age;
            }
            else
            {
                Console.WriteLine($"Возраст пользователя: {Properties.Settings.Default.UserAge}");
            }

            if (string.IsNullOrEmpty(Properties.Settings.Default.UserSpecial))
            {
                Console.Write("Специальность пользователя: ");
                Properties.Settings.Default.UserSpecial = Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Специальность пользователя: {Properties.Settings.Default.UserSpecial}");
            }
            Properties.Settings.Default.Save();
        }
    }
}
