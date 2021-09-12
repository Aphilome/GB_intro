using System;
using System.Text;

namespace NavalBattleFieldPrinter
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            string[] letters = {"А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "К"};
            Console.WriteLine($"{' ', 3}{1, 3}{2, 3}{3, 3}{4, 3}{5, 3}{6, 3}{7, 3}{8, 3}{9, 3}{10, 3}");
            char[,] navalBattleFieldMatrix =
            {
                {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'O', 'X', 'X', 'O', 'O'},
                {'O', 'X', 'O', 'X', 'X', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'X', 'O', 'O', 'O', 'O', 'O', 'X', 'O', 'O'},
                {'O', 'O', 'O', 'X', 'X', 'X', 'O', 'O', 'O', 'O'},
                {'O', 'O', 'X', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
                {'O', 'O', 'O', 'X', 'O', 'O', 'X', 'O', 'O', 'O'},
                {'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O', 'O'},
            };

            for (byte i = 0; i < navalBattleFieldMatrix.GetLength(0); i++)
            {
                Console.Write($"{letters[i], 3}");
                for (int j = 0; j < navalBattleFieldMatrix.GetLength(1); j++)
                    Console.Write($"{navalBattleFieldMatrix[i, j], 3}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}