/*Liam Tiemon*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler046 {
    class Program {
        const int NUMS = 10000;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            List<int> oddComp = calcOddComp();
            int[] primes = ESieve(NUMS);
            bool check;


            foreach (var oddNum in oddComp) {
                check = false;
                foreach (var primeNum in primes) {
                    int i = primeNum;
                    for (int sq = 1; sq < oddNum; sq++) {
                        if (oddNum == (i + (2 * Math.Pow(sq, 2)))) {
                            //Console.WriteLine("{0} = {1} + 2x{2}^2", oddNum, i, sq);
                            check = true;
                            break;
                        }
                    }
                    if (check)
                        break;
                }
                if (check == false) {
                    Console.WriteLine("smallest odd composite: {0}", oddNum);
                    break;
                }
            }
            s.Stop();
            Console.WriteLine("solution took: {0} ms", s.ElapsedMilliseconds);
        }
        public static List<int> calcOddComp() {
            List<int> oddComp = new List<int>();


            for (int i = 1; i < NUMS; i += 2) {
                int num = 2;
                while (num <= i - 1) {
                    if (i % num == 0) {
                        oddComp.Add(i);
                        break;
                    }
                    ++num;
                }
            }

            return oddComp;
        }
        public static int[] ESieve(int upperLimit) {
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

            return numbers.ToArray();
        }
    }
}
