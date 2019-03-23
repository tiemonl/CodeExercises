using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventOfCode03 {
	class Program {
		static void Main(string[] args) {
			int input = 265149;
			int n = closestSquare(input);
			int distance = (n*n) - input;
			Console.WriteLine(CalculateManhattanDistance(n-1,n/2,n-1, n/2) - distance);
			//this works for my input as it's close enough to the odd square and I don't have to spiral when I find the distance.
		}
		public static int CalculateManhattanDistance(int x1, int x2, int y1, int y2) {
			return Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
		}
		public static int closestSquare(int x) {
			int num = (int)Math.Floor(Math.Sqrt(x));
			return num % 2 == 0 ? ++num : num;
		}
	}
}
