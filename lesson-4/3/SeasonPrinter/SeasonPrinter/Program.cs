using System;
using System.Text;

namespace SeasonPrinter
{
    public enum SeasonsEnum
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
    
    class Program
    {
        static SeasonsEnum GetSeason(byte month)
        {
            if (month is 1 or 2 or 12)
                return SeasonsEnum.Winter;
            if (month is 3 or 4 or 5)
                return SeasonsEnum.Spring;
            if (month is 6 or 7 or 8)
                return SeasonsEnum.Summer;
            return SeasonsEnum.Autumn;
        }

        static string GetSeasonString(SeasonsEnum season)
        {
            switch (season)
            {
                 case SeasonsEnum.Winter:
                     return "Зима";
                 case SeasonsEnum.Spring:
                     return "Весна";
                 case SeasonsEnum.Summer:
                     return "Лето";
                 case SeasonsEnum.Autumn:
                     return "Осень";
            }
            return string.Empty;
        }
        
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Input month number: ");
            if (!byte.TryParse(Console.ReadLine(), out byte month)
                || month is not (> 0 and < 13))
            {
                Console.WriteLine("Ошибка: введите число от 1 до 12");
                return;
            }
            SeasonsEnum season = GetSeason(month);
            Console.WriteLine($"Время года: {GetSeasonString(season)}");
        }
    }
}