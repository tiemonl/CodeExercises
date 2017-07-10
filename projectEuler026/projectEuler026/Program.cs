/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler026 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int high = 0;
            int highI = 0;
            for (int i = 3; i < 1000; i++) {
                if (i % 2 == 0 || i % 5 == 0) {
                    continue;
                }
                // Console.WriteLine((decimal)1 / i + " ");
                int[] num = long_division(1, i);
                if (num.Count() > high) {
                    high = num.Count();
                    highI = i;
                }
            }
            s.Stop();
            Console.WriteLine("{0} is the highest denominator with a sequence of {1} digits.\nSolution took: {2} ms", highI, high, s.Elapsed.TotalMilliseconds);
        }
        public static int[] long_division(int numerator, int denominator) {
            if (numerator < 1 || numerator >= denominator) throw new Exception("Bad call");
            int[] digits = new int[denominator];
            int k = 0, n = numerator;
            do {
                n *= 10;
                digits[k++] = n / denominator;
                n = n % denominator;
            } while (n != numerator);
            int[] period = new int[k];
            for (n = 0; n < k; ++n) {
                period[n] = digits[n];
            }
            return period;
        }
    }
}
