using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler015 {
    class Program {
        //I noticed that lattice paths on a square is related to pascals triangle, so I made a matrix that would basically calculate the pascal triangles to 20,20
        const int ROW = 21;//off by one error
        const int COL = 21;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            long[,] grid = new long[ROW, COL];
            //put ones in all the top rows and cols
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
                        grid[row, col] += grid[row - 1, col]+grid[row,col-1];
                }
            }
            Console.WriteLine(grid[ROW - 1, COL - 1]);
            s.Stop();
            Console.WriteLine("Solutiont took {0} ms", s.Elapsed.TotalMilliseconds);
        }
    }
}
