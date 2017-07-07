using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler010 {
    class Program {
        const int PRIME_LIMIT = 2000000;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            List<int> primes = ESieve(PRIME_LIMIT);
            long total = 0;
            foreach (var item in primes) {
                total += item;
            }
            Console.WriteLine(total);
            s.Stop();
            Console.WriteLine("Solution took {0} ms",s.Elapsed.TotalMilliseconds);
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
