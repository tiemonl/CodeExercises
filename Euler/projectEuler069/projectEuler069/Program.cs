/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler069 {
    class Program {
        static void Main(string[] args) {
            //after a bit of analysis, i found that it was uncessary to actually calculate any totient.
            //the highest n will always be the product of consecutive primes less than the limit. 
            //so all we have to do is multiply consecutive primes until we reach the highest value less than one million.
            Stopwatch s = Stopwatch.StartNew();
            int answer = 2; //first prime
            for (int i = 3; i < int.MaxValue; i++) {
                if (isPrime(i)) {
                    if (answer*i>1000000) {
                        break;
                    }
                    answer *= i;
                }
            }
            s.Stop();
            Console.WriteLine("{0}\nSolution took {1} ms",answer, s.Elapsed.TotalMilliseconds);
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
