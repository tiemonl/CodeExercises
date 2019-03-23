/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler024 {
    class Program {
        static void Main(string[] args) {

            Stopwatch s = Stopwatch.StartNew();
            //There are 10! permutations of 0123456789
            //There are 9! permutations of 123456789 = 362880
            //So for numbers beginning with 0 and 1 there are 725760 permutations
            //Thus we want the 1000000 - 725760 = 274240. permutation in the 2xxxxxxxxx group.
            //20xxxxxxxx has 8! permutations = 40320. 274240/40320 = 6.8....etc
            char[] result = new char[10];
            double permutation = 1000000;
            string perms = "0123456789";
            for (int i = perms.Length - 1; i >= 0; i--) {
                int index = (int)Math.Ceiling(permutation / Factorial(perms.Length - 1)) - 1;
                result[i] = perms[index];
                perms = perms.Remove(index, 1);
                permutation -= Factorial(i) * index;
            }
            Array.Reverse(result);
            s.Stop();
            Console.WriteLine("The millionth lexicographic permutation is: {0}\nSolution took {1} ms", new string(result), s.Elapsed.TotalMilliseconds);
        }
        public static double Factorial(int n) {
            int factorial = 1;
            for (int i = 1; i <= n; i++) {
                factorial *= i;
            }
            return factorial;
        }
    }
}
