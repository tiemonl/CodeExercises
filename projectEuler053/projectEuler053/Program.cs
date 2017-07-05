using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler053 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            //BigInteger num = Factorial(100);
            BigInteger count = 0;
            for (int n = 1; n <= 100; n++) {
                for (int r = 1; r <= n; r++) {
                    if (combinatorics(n, r) >= 1000000)
                        ++count;
                }
            }
            s.Stop();
            Console.WriteLine("There are {0} values of combinatorics greater than one million.\nSolution took: {1} ms", count, s.ElapsedMilliseconds);
        }
        static BigInteger Factorial(BigInteger i) {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
        static BigInteger combinatorics(BigInteger n, BigInteger r) {
            BigInteger answer = 1;
            answer = (Factorial(n)) / (Factorial(r) * (Factorial(n - r)));
            return answer;
        }
    }
}
