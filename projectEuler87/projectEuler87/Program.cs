using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler87 {
    class Program {
        const int numMax = 50000000;
        //static List<int> primes = ESieve(7072);
        //static List<int> primes1 = ESieve(369);
        //static List<int> primes2 = ESieve(85);
        static void Main(string[] args) {
            Stopwatch clock = Stopwatch.StartNew();

            long[] primes = ESieve(7071);
            long[][] powers = new long[3][];
            int target = 50000000;

            List<long> templist = new List<long>(primes);
            for (int j = 0; j < 3; j++) {
                for (int i = 0; i < primes.Length; i++) {
                    templist[i] *= primes[i];
                }
                powers[j] = templist.ToArray();
            }

            SortedSet<long> numbers = new SortedSet<long>();

            for (int i = 0; i < primes.Length; i++) {
                for (int j = 0; j < primes.Length; j++) {
                    for (int k = 0; k < primes.Length; k++) {
                        long number = powers[0][i] + powers[1][j] + powers[2][k];
                        if (number > target) break;
                        numbers.Add(number);
                    }
                }
            }

            clock.Stop();
            Console.WriteLine("There are {0} numbers", numbers.Count);
            Console.WriteLine("Solution took {0} ms", clock.Elapsed.TotalMilliseconds);
            //Console.WriteLine(powerTriples());
        }
        //public static int powerTriples() {
        //    List<double> count = new List<double>();
        //    foreach (var one in primes) {
        //        foreach (var two in primes1) {
        //            if (Math.Pow(one, 2) + Math.Pow(two, 3) >= numMax) {
        //                break;
        //            }
        //            foreach (var three in primes2) {
        //                double answer = Math.Pow(one, 2) + Math.Pow(two, 3) + Math.Pow(three, 4);
        //                if (answer >= numMax) { break; }
        //                Console.WriteLine("{0} {1} {2} {3}", answer, one, two, three);
        //                if (!count.Contains(answer)) {
        //                    count.Add(answer);
        //                }
        //            }
        //        }
        //    }
        //    return count.Count;
        //}
        public static long[] /*List<int>*/ ESieve(int upperLimit) {
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

            List<long> numbers = new List<long>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++) {
                if (PrimeBits.Get(i)) {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }
    }
}
