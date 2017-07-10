/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler016 {
    class Program {
        static void Main(string[] args) {
            //biginteger made this really trivial.
            Stopwatch s = Stopwatch.StartNew();
            BigInteger num = BigInteger.Pow(2, 1000);
            int sum = 0;
            foreach (var item in num.ToString()) {
                sum += int.Parse(item.ToString());
            }
            Console.WriteLine(sum);
            s.Stop();
            Console.WriteLine("soluution took {0} ms", s.Elapsed.TotalMilliseconds);
        }
    }
}
