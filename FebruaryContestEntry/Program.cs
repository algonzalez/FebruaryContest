using System;

namespace FebruaryContestEntry
{
	class Program
	{
		const char block = '▓';
		const int widthInColumns = 30;
		const int heightInRows = 15;

		static void Main()
		{
			var rowBorder = new string(block, widthInColumns);
			var rowInternal = new string(block, widthInColumns - 2);

			WriteLineInColor(rowBorder, ConsoleColor.Green);

			int internalCount = heightInRows - 2;
			for (int _ = 0; _ < internalCount; _++)
			{
				WriteCharInColor(block, ConsoleColor.Green);
				WriteInColor(rowInternal, ConsoleColor.Yellow);
				WriteCharInColor(block, ConsoleColor.Green);
				Console.WriteLine();
			}

			WriteLineInColor(rowBorder, ConsoleColor.Green);

			Console.ResetColor();
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Yay, a colorful shape!");
			Console.ReadLine();
		}

		static void WriteInColor(string value, ConsoleColor foregroundColor)
		{
			Console.ForegroundColor = foregroundColor;
			Console.Write(value);
		}

		static void WriteLineInColor(string value, ConsoleColor foregroundColor)
		{
			Console.ForegroundColor = foregroundColor;
			Console.WriteLine(value);
		}

		static void WriteCharInColor(char value, ConsoleColor foregroundColor)
		{
			Console.ForegroundColor = foregroundColor;
			Console.Write(value);
		}
	}
}