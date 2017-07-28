/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler003 {
    class Program {
        const long masterNum = 600851475143;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            long largestFact = primeCheck(masterNum);
            s.Stop();
            Console.WriteLine("Largest prime factor of the number 600851475143 is: {0}\nSolution took: {1} ms",largestFact,s.Elapsed.TotalMilliseconds);
        }
        public static long primeCheck(long n) {
            int i;
            while (n % 2 == 0) n /= 2;
            if (n == 1) return 2;
            for (i = 3; i <= Math.Sqrt(n); i += 2) {
                while (n % i == 0) {
                    n /= i;
                }
            }
            if (n > 2) {
                return n;
            } else {
                return i - 2;
            }
        }
    }
}
