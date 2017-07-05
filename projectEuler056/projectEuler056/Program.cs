using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler056 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            BigInteger highest = 0;
            for (int a = 0; a < 100; a++) {
                for (int b = 0; b < 100; b++) {
                    BigInteger answer = BigInteger.Pow(a, b);
                    if (findSum(answer) > highest) {
                        highest = findSum(answer);
                    }
                }
            }
            s.Stop();
            Console.WriteLine("Highest digital sum is: {0}\nsolution took: {1} ms", highest, s.ElapsedMilliseconds);
        }
        static int findSum(BigInteger num) {
            int sum = 0;

            char[] chaa = num.ToString().ToCharArray();
            foreach (var item in chaa) {
                sum += int.Parse(item.ToString());
            }

            return sum;
        }
    }
}
