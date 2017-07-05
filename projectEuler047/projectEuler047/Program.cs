using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler047 {
    class Program {
        static List<int> primes = ESieve(500);
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int count = 0;
            int i = 0;
            int target = 4;
            while (count < target) {
                i++;
                if (checkDistinct(i) >= target) {
                    count++;
                } else {
                    count = 0;
                }
            }
            s.Stop();
            Console.WriteLine("The first of the {0} consecutive integers to have {1} distinct prime factors is {2}\nsolution took: {3} ms", target, target, i - target + 1, s.ElapsedMilliseconds);
        }

        public static int checkDistinct(int i) {
            int divisors = 0;
            bool pf;
            int num = i;
            foreach (var prime in primes) {
                if (prime * prime > num) {
                    return ++divisors;
                }
                pf = false;
                //this loops to divide by the same prime to check if you can divide by that prime multiple times to figure out its exponent.
                while (num % prime == 0) {
                    pf = true;
                    num /= prime;
                }
                if (pf) {
                    divisors++;
                }
                if (num == 1) {
                    return divisors;
                }
            }
            return divisors;
        }

        public static List<int> ESieve(int upperLimit) {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++) {
                if (PrimeBits.Get(i)) {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++) {
                if (PrimeBits.Get(i)) {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers;
        }
    }
}
