/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler007 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int count = 0;
            int prime = 0;
            for (int i = 0; i < int.MaxValue; i++) {
                if (isPrime(i)) {
                    ++count;
                }
                if (count==10001) {
                    prime = i;
                    break;
                }
            }
            Console.WriteLine(prime);
            s.Stop();
            Console.WriteLine("solution took {0} ms", s.Elapsed.TotalMilliseconds);
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
