using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
	static void Main(String[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t; a0++) {
			int rows = Convert.ToInt32(Console.ReadLine());
			int[][] nums = new int[rows][];
			for (int row = 0; row < rows; row++) {
				string[] tokens = Console.ReadLine().Split();
				nums[row] = new int[tokens.Length];
				for (int i = 0; i < tokens.Length; i++) {
					nums[row][i] = int.Parse(tokens[i]);
				}
			}
	   
			for (int i = nums.Length - 1; i > 0; --i) {
				for (int j = 1; j < nums[i].Length; j++) {
					if (nums[i][j - 1] > nums[i][j])
						nums[i - 1][j - 1] += nums[i][j - 1];
					else
						nums[i - 1][j - 1] += nums[i][j];
				}
			}
			Console.WriteLine(nums[0][0]);
		}
	}
}