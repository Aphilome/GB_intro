using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace TaskManager
{
    class Program
    {
        static void Main()
        {
            Process[] processes = Process.GetProcesses();
            Console.WriteLine($"{"Id",-10}|   {"Process name",-60}");
            Console.WriteLine($"{new string('—', 70)}");
            foreach (var i in processes)
            {
                Console.WriteLine($"{i.Id,-10}|   {i.ProcessName,-60}");
            }
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.InputEncoding = Encoding.UTF8;
            }
            Console.Write("Введите Id или имя процесса для завершения: ");
            string completionProcess = Console.ReadLine();
            if (int.TryParse(completionProcess, out int id))
            {
                try
                {
                    var p = Process.GetProcessById(id);
                    Console.WriteLine($"Завершение процесса id: {p.Id}, name: {p.ProcessName}");
                    p.Kill();
                }
                catch (Exception)
                {
                    Console.WriteLine("По id не удалось осуществить поиск. Попробуйте искать по имени.");
                }
            }

            Process[] ps = Process.GetProcessesByName(completionProcess);
            if (ps.Length == 0)
            {
                Console.WriteLine("Процессы по имени не найдены");
                return ;
            }
            foreach (var i in ps)
            {
                Console.WriteLine($"Завершение процесса id: {i.Id}, name: {i.ProcessName}");
                i.Kill();
            }
        }
    }
}