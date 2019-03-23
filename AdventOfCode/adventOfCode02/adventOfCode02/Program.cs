using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode02 {
	class Program {
		static void Main(string[] args) {
			int low = int.MaxValue, high = 0, sum = 0;
			int[][] list = File.ReadAllLines("../../nums.txt")
				   .Select(l => l.Split('\t').Select(i => int.Parse(i)).ToArray())
				   .ToArray();
			for (int col = 0; col < 16; col++) {
				low = int.MaxValue;
				high = 0;
				for (int row = 0; row < 16; row++) {
					if (list[col][row] > high) {
						high = list[col][row];
					}
					if (list[col][row] < low) {
						low = list[col][row];
					}
				}
				sum += Math.Abs(high - low);
			}
			Console.WriteLine("answer is {0}", sum);
		}
	}
}
