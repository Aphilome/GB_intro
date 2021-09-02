using System;
using System.Text;

namespace OfficeWeekTimetable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            // _ПВСЧПСВ
            // 01100011
            byte gB = 0b01111111;
            byte fxf = 0b01111100;
            PrintWorkDays(gB, "GeekBrains");
            PrintWorkDays(fxf, "Foxford");
        }

        static void PrintWorkDays(byte office, string name)
        {
            Console.WriteLine($"-- {name} --");
            Console.WriteLine("ПН ВТ СР ЧТ ПТ СБ ВС");
            byte mask = 0b01000000;
            while (mask > 0)
            {
                if ((office & mask) == 0)
                    Console.Write("   ");
                else
                    Console.Write(" ✓ ");
                mask = (byte)(mask >> 1);
            }
            Console.WriteLine();
        }
    }
}