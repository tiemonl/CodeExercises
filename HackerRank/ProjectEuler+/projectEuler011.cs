using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
	const int GRID_SIZE = 20;
	static void Main(String[] args) {
		int[,] grid = new int[GRID_SIZE, GRID_SIZE];
		int row = 0;
		int highestProduct = 1;
		int total = 1;
		for (int grid_i = 0; grid_i < 20; grid_i++) {
			string[] nums = Console.ReadLine().Split(' ');
			for (int i = 0; i < nums.Length; ++i) {
				grid[grid_i, i] = int.Parse(nums[i]);
			}
		}
		for (row = 0; row < GRID_SIZE; row++) {
			for (int col = 0; col < GRID_SIZE; col++) {

				if (row < GRID_SIZE - 3) {//horizontal (left to right) check
					for (int i = 0; i < 4; i++) {
						total *= grid[row + i, col];
					}
					if (total > highestProduct) {
						highestProduct = total;
					}
					total = 1;
				}
				if (col < GRID_SIZE - 3) {//vertical (up to down) check
					for (int i = 0; i < 4; i++) {
						total *= grid[row, col + i];
					}
					if (total > highestProduct) {
						highestProduct = total;
					}
					total = 1;
				}
				if (row < GRID_SIZE - 3 && col < GRID_SIZE - 3) {//diagonal (NW to SE) check
					for (int i = 0; i < 4; i++) {
						total *= grid[row + i, col + i];
					}
				if (total > highestProduct) {
						highestProduct = total;
					}
					total = 1;
				}
				if (row >= 3 && col < GRID_SIZE - 3) {//diagonal (SW to NE) check
					for (int i = 0; i < 4; i++) {
						total *= grid[row - i, col + i];
					}
					if (total > highestProduct) {
						highestProduct = total;
					}
					total = 1;
				}
			}
		}
		Console.WriteLine(highestProduct);
	}
}
