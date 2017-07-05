using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler072 {
    class Program {
        static void Main(string[] args) {
            SortedSet<decimal> ss = new SortedSet<decimal>();
            int s = 0;
            for (int d = 2; d <= 1000000; d++) {
                for (int n = 1; n < d; n++) {
                    //ss.Add((decimal)n / d);
                    if (GCD(n, d) == 1) {
                        s++;
                    }
                }
            }
            Console.WriteLine(s);
        }
        static int GCD(int a, int b) {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
