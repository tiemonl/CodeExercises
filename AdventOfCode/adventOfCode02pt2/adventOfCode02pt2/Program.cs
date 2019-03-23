using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode02pt2 {
	class Program {
		static void Main(string[] args) {
			int ans, sum = 0;
			int[][] list = File.ReadAllLines("../../nums.txt")
				   .Select(l => l.Split('\t').Select(i => int.Parse(i)).ToArray())
				   .ToArray();
			for (int col = 0; col < 16; col++) {
				ans = EvenDivisibility(col, list);
				sum += Math.Abs(ans);
			}
			Console.WriteLine("answer is {0}", sum);
		}

		public static int EvenDivisibility(int col, int[][] list) {
			for (int row = 0; row < 16; row++) {
				for (int i = 0; i < 16 - row; i++) {
					int a = list[col][row];
					int b = list[col][row + i];
					if (a != b) {//don't divide by itself
						if (a > b) {
							if (a % b == 0)
								return a / b;
						} else {
							if (b % a == 0)
								return b / a;
						}
					}
				}
			}
			return -1; //should not reach
		}
	}
}
