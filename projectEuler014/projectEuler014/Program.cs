using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler014 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int longestChain=0;
            int numWithLongestChain = 0;
            int check = collatz(27);
            for (int i = 2; i < 1000000; i++) {
                int chain = collatz(i);
                if (longestChain<chain) {
                    longestChain = chain;
                    numWithLongestChain = i;
                }
            }
            Console.WriteLine(check);
            Console.WriteLine(numWithLongestChain);
            s.Stop();
            Console.WriteLine("solution took {0} ms",s.Elapsed.TotalMilliseconds);
        }
        public static int collatz(long number) {
            int chain = 1;
            while (number > 1) {
                if (number % 2 == 0) {
                    number /= 2;
                    ++chain;
                } else {
                    number = (number*3) + 1;
                    ++chain;
                }
            }
            return chain;
        }
    }
}
