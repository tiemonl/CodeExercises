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
            long largestFact = 0;
            for (long i = 2; i*i < masterNum; i++) {//only need to check up to sqrt of num
                if (masterNum % i == 0) { //check to see if i is a divisor of the number.
                    bool isPrime = true;
                    for (long j = 2; j < i; j++) {
                        if (i%j ==0) { //check to see if i has any divisors, if not, it is prime.
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime) {
                        largestFact = i;
                    }
                }
            }
            s.Stop();
            Console.WriteLine("Largest prime factor of the number 600851475143 is: {0}\nSolution took: {1} ms",largestFact,s.Elapsed.TotalMilliseconds);
        }
    }
}
