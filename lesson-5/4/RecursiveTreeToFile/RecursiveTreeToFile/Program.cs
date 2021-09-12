using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace RecursiveTreeToFile
{
	class Program
	{
		/*
		
		 |-📂 root
		 |- 📂 dir1
			|- 📂 dir11
			|- 📄 file11
		 |- 📂 dir2
			|- 📂 dir21
			|- 📄 file21
		 
		 */

		private static string _workDir;
		
		private static string TreeFileName => $"{Path.Combine(_workDir, "Tree.txt")}";
		private static string ListFileName => $"{Path.Combine(_workDir, "List.txt")}";

		static void SimplePrinter(string directory)
		{
			string[] entries = Directory.GetFileSystemEntries(directory, "*", SearchOption.AllDirectories);
			for (int i = 0; i < entries.Length; i++)
				File.AppendAllText(ListFileName,$"{entries[i]}\n");
		}
		
		static void TreePrinterRecoursive(string directory, string tabs)
		{
			File.AppendAllText(TreeFileName, $"{tabs}|-📂 {new DirectoryInfo(directory).Name}\n");
			string[] entries = Directory.GetFileSystemEntries(directory,
				"*", SearchOption.TopDirectoryOnly);
			List<string> directories = entries
				.Where(i => Directory.Exists(i))
				.ToList();
			List<string> files = entries
				.Where(i => !directories.Contains(i))
				.ToList();
			directories.Sort();
			files.Sort();

			foreach (var i in directories)
				TreePrinterRecoursive(i, "\t" + tabs);
			foreach (var i in files)
				File.AppendAllText(TreeFileName, $"\t{tabs}|-📄 {Path.GetFileName(i)}\n");
		}
		
		static void Main()
		{
			Console.OutputEncoding = Encoding.Unicode;
			Console.InputEncoding = Encoding.Unicode;
			if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
			{
				Console.OutputEncoding = Encoding.UTF8;
				Console.InputEncoding = Encoding.UTF8;
			}
			
			Console.Write("Задайте путь к директории для " +
							"сохранения дерева каталогов и файлов плез: ");
			string workDir = Console.ReadLine();
			if (!Directory.Exists(workDir))
			{
				Console.WriteLine("Директории не существует");
				return ;
			}
			_workDir = workDir;
			File.WriteAllText(TreeFileName, "");
			File.WriteAllText(ListFileName, "");
			// File.Delete(TreeFileName);
			TreePrinterRecoursive(workDir, "");
			Console.WriteLine($"Дерево каталогов и файлов записано в файле {TreeFileName}");
			SimplePrinter(_workDir);
			Console.WriteLine($"Список каталогов и файлов записан в файле {ListFileName}");

		}
	}
}
