using System;
namespace Qbby {
	class Program {
		static void Main(string[] args) {
			Console.Title = "Qbby";
			Console.CursorVisible = false;
			Console.BufferWidth = 88;
			Console.WindowWidth = 88;
			Console.BufferHeight = 26;
			Console.WindowHeight = 26;

			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.Clear();
			
			while (true) {
				Console.SetCursorPosition(0, 0);
				MZG.Read("Data/Qbby.mzg");
				System.Threading.Thread.Sleep(2500);
				Console.SetCursorPosition(0, 0);
				MZG.Read("Data/Qbby_blink.mzg");
				System.Threading.Thread.Sleep(200);
			}
		}
	}
}