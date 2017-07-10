/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler012 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int count = 0;
            int triangleNumber = 0;
            for (int i = 1; count < 500; i++) {
                triangleNumber += i;
                count = getFactors(triangleNumber);
            }
            Console.WriteLine(triangleNumber);
            s.Stop();
            Console.WriteLine("solution took {0} ms",s.Elapsed.TotalMilliseconds);
        }
        public static int getFactors(int triNum) {
            int factors = 0;
            for (int i = 1; i <= Math.Sqrt(triNum); i++) {
                if (triNum % i == 0) {
                    factors += 2;
                }
            }
            return factors;
        }
    }
}
