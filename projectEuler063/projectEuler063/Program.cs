using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler063 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int counter = 0;
            for (int a = 1; a < 10; a++) {
                for (int b = 1; b < 25; b++) {
                    BigInteger answer = BigInteger.Pow(a, b);
                    if (answer.ToString().Length == b) {
                        ++counter;
                    }
                }
            }
            s.Stop();
            Console.WriteLine("There are {0} numbers which their length are equal to their power.\nSolution took: {1} ms", counter, s.Elapsed.TotalMilliseconds);
        }
    }
}
