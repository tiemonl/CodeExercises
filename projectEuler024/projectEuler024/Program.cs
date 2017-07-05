using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler024 {
    class Program {
        static void Main(string[] args) {

            Stopwatch sw = Stopwatch.StartNew();
            //There are 10! permutations of 0123456789
            //There are 9! permutations of 123456789 = 362880
            //So for numbers beginning with 0 and 1 there are 725760 permutations
            //Thus we want the 1000000 - 725760 = 274240. permutation in the 2xxxxxxxxx group.
            //20xxxxxxxx has 8! permutations = 40320. 274240/40320 = 6.8....etc
            char[] result = new char[10];
            double permutation = 1000000;
            string s = "0123456789";
            for (int i = s.Length - 1; i >= 0; i--) {
                double index = Math.Ceiling(permutation / FactorialSmallInt(s.Length - 1)) - 1;
                result[i] = s[(int)index];
                s = s.Remove((int)index, 1);
                permutation -= FactorialSmallInt(i) * index;
            }
            Array.Reverse(result);
            sw.Stop();
            Console.WriteLine("The millionth lexicographic permutation is: {0}\nSolution took {1} ms", new string(result), sw.Elapsed.TotalMilliseconds);
        }
        public static double FactorialSmallInt(int n) {
            int factorial = 1;
            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }
            return factorial;
        }
    }
}
