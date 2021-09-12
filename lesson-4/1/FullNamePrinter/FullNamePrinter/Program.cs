using System;
using System.Text;

namespace FullNamePrinter
{
    class Program
    {
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{firstName} {lastName} {patronymic}";
        }
        
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine($"{GetFullName("Федор", "Михайлович", "Достоевский")}" +
                              $", \n" +
                              $"{GetFullName("Михаил", "Афанасьевич", "Булгаков")}" +
                              $", \n" +
                              $"{GetFullName("Александр", "Сергеевич", "Пушкин")}" +
                              $", \n" +
                              $"{GetFullName("Лев", "Николаевич", "Толстой")}");
        }
    }
}