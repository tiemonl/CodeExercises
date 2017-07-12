/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler072 {
    class Program {
        static void Main(string[] args) {
            //at first i tried to just go through each possibility and divide and count how many unique answers there are by storing them in a set.
            //then i just decided to see if there was a GCD and if there wasn't, add one to a counter, but going through every possibility takes a while.
            //still trying to figure out a faster way of doing this.
            //after some research, i found out that i was basically calculating the sum of Euler;s totient function, so now, I have to optimise that. which a sieve is the only thing that makes sense.

            Stopwatch sw = Stopwatch.StartNew();

            int limit = 1000000;
            int[] phii = Enumerable.Range(0, limit + 1).ToArray();
            long result = 0;
            for (int i = 2; i <= limit; i++) {
                if (phii[i] == i) {
                    for (int j = i; j <= limit; j += i) {
                        phii[j] = phii[j] / i * (i - 1);
                    }
                }
                result += phii[i];
            }
            sw.Stop();
            Console.WriteLine("{0}\t\t{1} ms", result, sw.Elapsed.TotalMilliseconds);
            sw.Restart();
            int sum = 0;
            for (int i = 2; i <= limit; i++) {
                if (isPrime(i)) {
                    sum += i - 1;
                } else {
                    sum += phi(i);
                }
                
            }
            sw.Stop();
            Console.WriteLine("{0}\t\t{1} ms",sum,sw.Elapsed.TotalMilliseconds);
            sw.Restart();
            //SortedSet<decimal> ss = new SortedSet<decimal>();
            int s = 0;
            for (int d = 2; d <= limit; d++) {
                for (int n = 1; n < d; n++) {
                    //ss.Add((decimal)n / d);
                    if (GCD(n, d) == 1) {
                        s++;
                    }
                }
            }
            sw.Stop();
            Console.WriteLine("{0}\t\t{1} ms", s, sw.Elapsed.TotalMilliseconds);
        }
        static int GCD(int a, int b) {
            return b == 0 ? a : GCD(b, a % b);
        }
        static int phi(int n) {
            int result = 1;
            for (int i = 2; i < n; i++)
                if (GCD(i, n) == 1)
                    result++;
            return result;
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
