/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler029 {
    class Program {
        static void Main(string[] args) {
            List<BigInteger> list = new List<BigInteger>();
            Stopwatch s = new Stopwatch();
            s.Start();
            for (BigInteger a = 2; a <= 100; a++) {
                for (int b = 2; b <= 100; b++) {
                    list.Add(BigInteger.Pow(a, b));
                }
            }
            Console.WriteLine("List filled.");
            List<BigInteger> distinct = list.Distinct().ToList();
            distinct.Sort();
            Console.WriteLine("Removed duplicates.\nTotal distinct terms: {0}", distinct.Count);
            s.Stop();
            Console.WriteLine("solution took {0} ms", s.Elapsed.TotalMilliseconds);
        }
    }
}
