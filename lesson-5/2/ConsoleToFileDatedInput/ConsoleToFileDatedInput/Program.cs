using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace ConsoleToFileDatedInput
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
			
			try
			{
				File.AppendAllText("startup.txt",
					$"{DateTime.Now}\n");
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				return ;
			}
			Console.WriteLine("Текущее время успешно дозаписано в файл 'startup.txt'");
		}
	}
}
