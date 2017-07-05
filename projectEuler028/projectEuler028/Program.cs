using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler028 {
    class Program {
        const int ROWS = 1001;
        const int COLS = 1001;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int[,] matrix = new int[ROWS, COLS];
            spiralOrder(matrix);
            //readMatrix(matrix);
            s.Stop();
            Console.WriteLine("Sum of diagonals: {0}\nTime it took to run: {1} ms", calcDiag(matrix), s.ElapsedMilliseconds);
        }
        public static void spiralOrder(int[,] matrix) {
            int levl;
            int c = COLS / 2;
            int x, y;
            x = y = c;
            int i = 1;

            for (levl = 1; c + levl <= COLS; levl++) {
                for (; y <= c + levl && y < COLS; y++) { // go right
                    matrix[x, y] = i;
                    ++i;
                }

                if (x == 0 && y == COLS)
                    break;

                for (x++, y--; x <= c + levl && x < COLS; x++) {  // go down
                    matrix[x, y] = i;
                    ++i;
                }
                for (x--, y--; y >= c - levl; y--) {  // go left
                    matrix[x, y] = i;
                    ++i;
                }
                for (x--, y++; x >= c - levl; x--) {   // go up
                    matrix[x, y] = i;
                    ++i;
                }
                x++;
                y++;
            }

        }
        public static BigInteger calcDiag(int[,] matrix) {
            int i, j;
            BigInteger total = -1;
            i = j = ROWS - 1;

            while (i != -1) {
                //Console.WriteLine("i: {0} j: {1}, val: {2}",i,j,matrix[i, j]);
                total += matrix[i, j];
                i--;
                j--;
            }
            j = matrix.GetLength(0) - 1;
            i = 0;
            //Console.WriteLine();
            while (j != -1) {
                //Console.WriteLine("i: {0} j: {1}, val: {2}", i, j, matrix[i, j]);
                total += matrix[i, j];
                i++;
                j--;
            }
            return total;
        }
        public static void readMatrix(int[,] matrix) {
            int levl;
            int c = COLS / 2;
            int x, y;
            x = y = c;

            for (levl = 1; c + levl <= COLS; levl++) {
                for (; y <= c + levl && y < COLS; y++) // go right
                    Console.WriteLine(matrix[x, y]);


                if (x == 0 && y == COLS)
                    break;

                for (x++, y--; x <= c + levl && x < COLS; x++)  // go down
                    Console.WriteLine(matrix[x, y]);
                for (x--, y--; y >= c - levl; y--)    // go left
                    Console.WriteLine(matrix[x, y]);
                for (x--, y++; x >= c - levl; x--)     // go up
                    Console.WriteLine(matrix[x, y]);
                x++;
                y++;

            }
        }
    }
}
