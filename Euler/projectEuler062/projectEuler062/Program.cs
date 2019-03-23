using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler062 {
    class Program {
        const int limit = 10000;
        const int streak = 5;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            string[] cube = new string[limit];
            for (int i = 0; i < limit; i++) {
                cube[i] = order(Math.Pow(i, 3).ToString());
            }
            long[] answer = permutations(cube);
            Console.WriteLine(Math.Pow(answer[0],3));
            s.Stop();
            Console.WriteLine("solution took {0} ms", s.Elapsed.TotalMilliseconds);
        }

        public static string order(string str) {
            char[] strToSort = str.ToArray();
            Array.Sort(strToSort);
            return new string(strToSort);
        }
        public static long[] permutations(string[] cube) {
            long[] perms = new long[streak];

            for (int i = 345; i < limit; i++) {
                perms = new long[streak];
                int s = 0;
                for (int j = i; j < limit; j++) {
                    if (cube[i]== cube[j]) {
                        perms[s] = j;
                        ++s;
                    }
                    if (s == streak) {
                        return perms;
                    }
                }
            }
            return perms;
        }
    }
}
