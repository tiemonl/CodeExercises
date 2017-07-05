using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler045 {
    class Program {
        const int NUM = 1000000;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            List<BigInteger> hex = calcHexagonals();
            List<BigInteger> tri = calcTriangles();
            List<BigInteger> pent = calcPentagons();
            BigInteger count = 0;
            foreach (var r in hex.Intersect(tri.Intersect(pent))) {
                count++;
                if (count == 3) {
                    Console.WriteLine(r);
                    break;
                }
            }
            s.Stop();
            Console.WriteLine("Solution took: {0} ms", s.ElapsedMilliseconds);
        }
        private static List<BigInteger> calcPentagons() {
            List<BigInteger> list = new List<BigInteger>();
            for (BigInteger i = 0; i < NUM; i++) {
                list.Add((i + 1) * ((3 * (i + 1)) - 1) / 2);
            }
            return list;
        }
        private static List<BigInteger> calcTriangles() {
            List<BigInteger> list = new List<BigInteger>();
            for (BigInteger i = 0; i < NUM; i++) {
                list.Add((i + 1) * ((i + 1) + 1) / 2);
            }
            return list;
        }
        private static List<BigInteger> calcHexagonals() {
            List<BigInteger> list = new List<BigInteger>();
            for (BigInteger i = 0; i < NUM; i++) {
                list.Add((i + 1) * ((2 * (i + 1)) - 1));
            }
            return list;
        }
    }
}
