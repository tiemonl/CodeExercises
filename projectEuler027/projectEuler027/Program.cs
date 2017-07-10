using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler027 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int aHighest = 0, bHighest = 0, nHighest = 0;
            for (int a = -1000; a <= 1000; a++) {
                for (int b = -1000; b <= 1000; b++) {
                    int n = 0;
                    while (isPrime((int)Math.Abs(Math.Pow(n, 2) + (a*n) + b))) {
                        n++;
                    }
                    if (n>nHighest) {
                        aHighest = a;
                        bHighest = b;
                        nHighest = n;
                    }
                }
            }
            s.Stop();
            Console.WriteLine("product of a: {0} and b: {1} = {2} for the quadratic expession that produces the mac numbers of primes for values N\nSolution took {3} ms",aHighest,bHighest,(aHighest*bHighest),s.Elapsed.TotalMilliseconds);
        }
        private static bool isPrime(int n) {
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
