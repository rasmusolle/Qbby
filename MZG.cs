using System;
namespace Qbby {
	class MZG {
		private static void Modify(string text) {
			text = text.Replace('-', ' ');
			text = text.Replace('ü', '-');

			Console.WriteLine(text);
		}

		/// <summary>
		/// Reads a .mzg file and outputs the contents.
		/// </summary>
		public static void Read(string path) {
			int counter = 0;
			string line;

			try {
				System.IO.StreamReader file = new System.IO.StreamReader(path);
				while ((line = file.ReadLine()) != null) {
					if (counter == 0) {
						if (line != "MZGFILE1.0") {
							// You have nothing more to do here, exit the function.
							return;
						}
					} else {
						Modify(line);
					}
					counter++;
				}
				file.Close();
			} catch (System.IO.FileNotFoundException) { }
		}
	}
}