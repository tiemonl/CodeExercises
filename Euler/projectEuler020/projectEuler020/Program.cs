/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler020 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            BigInteger num = Factorial(100);
            int sum = 0;
            foreach (var item in num.ToString()) {
                sum += int.Parse(item.ToString());
            }
            Console.WriteLine(sum);
            s.Stop();
            Console.WriteLine("solution took {0} ms", s.Elapsed.TotalMilliseconds);
        }
        private static BigInteger Factorial(int number) {
            if (number == 0) {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}
