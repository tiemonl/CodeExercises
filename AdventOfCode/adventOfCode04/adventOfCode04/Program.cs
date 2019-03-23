using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode04 {
	class Program {
		static void Main(string[] args) {
			string line;
			int counter = 0;
			StreamReader file =new StreamReader(@"..\..\input.txt");
			while ((line = file.ReadLine()) != null) {
				string[] split = line.Split(' ');
				if (isUnique(split)) {
					counter++;
				}
			}

			file.Close();
			System.Console.WriteLine("There were {0} lines.", counter);
		}
		public static bool isUnique(string[] split) {
			for (int i = 0; i < split.Length-1; i++) {
				for (int j = i+1; j < split.Length; j++) {
					if (split[i] == split[j]) {
						return false;
					}
				}
			}
			return true;
		}
	}
}
