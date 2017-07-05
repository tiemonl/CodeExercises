using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler058 {
    class Program {
        const int ROWS = 27501;
        const int COLS = 27501;
        static void Main(string[] args) {
            //This is by no means a pretty solution considering i have to bypass the visual studio memory constraints to get the solution and it has to run on a 64 bit computer because of that, but it works decently quick...
            Stopwatch s = Stopwatch.StartNew();

            int[,] matrix = new int[ROWS, COLS];
            spiralOrder(matrix);
            int row = calcPrimesInDiag(matrix);
            //decimal numPrimes, percentagePrime = 100;
            //while (percentagePrime >= (decimal).10) {
            //    matrix = new int[ROWS += 2, COLS += 2];
            //    spiralOrder(matrix);
            //    numPrimes = calcDiag(matrix);
            //    percentagePrime = (decimal)numPrimes / (ROWS * 2 - 1);
            //    Console.WriteLine("ROWS: {0}; COLS: {1}; primes: {2}; diagNumbers: {3}; percentage: {4}%", ROWS, COLS, numPrimes, (ROWS * 2 - 1), percentagePrime);
            //}
            s.Stop();
            Console.WriteLine("Sum of diagonals: {0}\nSolution took: {1} ms", row, s.ElapsedMilliseconds);
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

        public static int calcPrimesInDiag(int[,] matrix) {
            int i, j;
            int diagNumbers = 5;
            int numPrimes = 0;
            i = j = ROWS / 2;
            decimal percentagePrime;
            int rowColNum = 0;
            for (int a = 1; a < ROWS; a++) {
                if (isPrime(matrix[i + a, j + a])) {
                    ++numPrimes;
                }
                if (isPrime(matrix[i - a, j + a])) {
                    ++numPrimes;
                }
                if (isPrime(matrix[i + a, j - a])) {
                    ++numPrimes;
                }
                if (isPrime(matrix[i - a, j - a])) {
                    ++numPrimes;
                }
                rowColNum = 2 * a + 1;
                percentagePrime = (decimal)numPrimes / diagNumbers;
                //Console.WriteLine("ROWS: {0}; COLS: {1}; primes: {2}; diagNumbers: {3}; percentage: {4}%", rowColNum, rowColNum, numPrimes, diagNumbers, percentagePrime);
                //Console.ReadLine();
                diagNumbers += 4;
                if (percentagePrime < (decimal).10) {
                    return rowColNum;
                }
            }

            return -1;
        }
        public static bool isPrime(int n) {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;
            if (n < 9) return true;
            if (n % 3 == 0) return false;

            long counter = 5;
            while ((counter * counter) <= n) {
                if (n % counter == 0) return false;
                if (n % (counter + 2) == 0) return false;
                counter += 6;
            }

            return true;
        }
    }
}
