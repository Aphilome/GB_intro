using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleToFileInput
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

			Console.Write("Ваша текстинфо плез: ");
			try
			{
				File.WriteAllText("ConsoleToFileInput.txt",
					Console.ReadLine());
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return ;
			}
			Console.WriteLine("Информация успешно записана в файл" +
							"'ConsoleToFileInput.txt'");
		}
	}
}
