using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleToBinaryFileInput
{
	class Program
	{
		static void Main()
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;
			if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
				Console.OutputEncoding = Encoding.UTF8;
				Console.InputEncoding = Encoding.UTF8;
			}
			
			Console.Write("Ваше число от 0 до 255 плез: ");
			if (!byte.TryParse(Console.ReadLine(), out byte number))
			{
				Console.WriteLine("Ошибка парсинга");
				return ;
			}
			try
			{
				File.WriteAllBytes("ConsoleToFileInput.bin",
					new []{number});
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return ;
			}
			Console.WriteLine("Число успешно записано в бинарный файл" +
							"'ConsoleToFileInput.bin'");
		}
	}
}
