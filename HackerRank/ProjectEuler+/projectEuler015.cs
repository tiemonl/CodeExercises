using System;
using System.Collections.Generic;
using System.IO;
class Solution {
	const int ROW = 501;//off by one error
	const int COL = 501;
	private static long[,] grid = new long[ROW, COL];
	static void Main(String[] args) {
		precomputeGrid();
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t; a0++) {
			string[] tokens_n = Console.ReadLine().Split(' ');
			int n = Convert.ToInt32(tokens_n[0]) + 1;
			int k = Convert.ToInt32(tokens_n[1]) + 1;
			Console.WriteLine((grid[n - 1, k - 1]));
		}
	}
	private static void precomputeGrid() {
		int row = 0;
		int col = 0;
		while (row < ROW - 1) {
			grid[row + 1, 0] = 1;
			row++;
		}
		while (col < COL - 1) {
			grid[0, col + 1] = 1;
			col++;
		}
		for (col = 1; col < COL; col++) {
			for (row = 1; row < ROW; row++) {
				grid[row, col] += grid[row - 1, col] + grid[row, col - 1];
				grid[row, col] %= (long)Math.Pow(10, 9) + 7;
			}
		}
	}
}