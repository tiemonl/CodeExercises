using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler81 {
    class Program {
        const int ROW = 80;
        const int COL = 80;
        static void Main(string[] args) {
            long[,] matrix = new long[ROW, COL];// { { 131, 673, 234, 103, 18 }, { 201, 96, 342, 965, 150 }, { 630, 803, 746, 422, 111 }, { 537, 699, 497, 121, 956 }, { 805, 732, 524, 37, 331 } };

            string input = File.ReadAllText("C:\\tri.txt");
            int i = 0, j = 0;
            foreach (var rows in input.Split('\n')) {
                j = 0;
                foreach (var cols in rows.Trim().Split(',')) {
                    matrix[i, j] = int.Parse(cols.Trim());
                    j++;
                }
                i++;
            }
            //calculate top row and side row first
            int row = 0;
            int col = 0;
            while (row<ROW-1) {
                matrix[row + 1, 0] += matrix[row, 0];
                row++;
            }
            while (col<COL-1) {
                matrix[0,col+1] += matrix[0, col];
                col++;
            }
            for (col = 1; col < COL; col++) {
                for (row = 1; row < ROW; row++) {
                    if (matrix[row, col] + matrix[row-1, col] < matrix[row, col] + matrix[row, col-1]) {
                        matrix[row, col] += matrix[row - 1, col];
                    } else {
                        matrix[row, col] += matrix[row, col - 1];
                    }
                }
                
            }
            Console.WriteLine(matrix[ROW-1, COL-1]);
        }
    }
}
