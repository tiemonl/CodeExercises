using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Diagnostics;

namespace projectEuler97 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            Console.WriteLine(28433 * BigInteger.ModPow(2, 7830457,10000000000) + 1);
            s.Stop();
            Console.WriteLine("Solution took {0} ms",s.ElapsedMilliseconds);
        }
    }
}
