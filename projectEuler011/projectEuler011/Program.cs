using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler011 {
    class Program {
        const int GRID_SIZE = 20;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int[,] grid = new int[GRID_SIZE, GRID_SIZE];
            int row = 0;
            int highestProduct = 1;
            int total = 1;
            StreamReader sr = new StreamReader("..\\..\\grid.txt");

            while (sr.Peek() >= 0) {
                string str = sr.ReadLine();
                string[] nums;
                nums = str.Split(' ');
                for (int i = 0; i<nums.Length; ++i) {
                    grid[row,i] = int.Parse(nums[i]);
                }
                ++row;
            }
            for (row = 0; row < GRID_SIZE; row++) {
                for (int col = 0; col < GRID_SIZE; col++) {

                    if (row< GRID_SIZE-4) {//horizontal (left to right) check
                        for (int i = 0; i < 4; i++) {
                            total *= grid[row + i, col];
                        }
                        if (total>highestProduct) {
                            highestProduct = total;
                        }
                        total = 1;
                    }
                    if (col < GRID_SIZE - 4) {//vertical (up to down) check
                        for (int i = 0; i < 4; i++) {
                            total *= grid[row, col + i];
                        }
                        if (total > highestProduct) {
                            highestProduct = total;
                        }
                        total = 1;
                    }
                    if (row < GRID_SIZE - 4 && col < GRID_SIZE - 4) {//diagonal (NW to SE) check
                        for (int i = 0; i < 4; i++) {
                            total *= grid[row + i, col+i];
                        }
                        if (total > highestProduct) {
                            highestProduct = total;
                        }
                        total = 1;
                    }
                    if (row < GRID_SIZE - 4 && col > 3) {//diagonal (SW to NE) check
                        for (int i = 0; i < 4; i++) {
                            total *= grid[row + i, col - i];
                        }
                        if (total > highestProduct) {
                            highestProduct = total;
                        }
                        total = 1;
                    }
                }
            }
            Console.WriteLine(highestProduct);
            s.Stop();
            Console.WriteLine("Solution took {0} ms",s.Elapsed.TotalMilliseconds);
        }
    }
}
