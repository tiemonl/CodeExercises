using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler092 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int counter = 0;
            for (int i = 2; i < 10000000; i++) {
                if (check(i)) {
                    ++counter;
                }
                //Console.WriteLine(i);
            }
            s.Stop();

            Console.WriteLine("{0} numbers below ten million arrive at 89\nSolution took {1} ms",counter,s.Elapsed.TotalMilliseconds);
        }
        static bool check(int n) {
            int num = n;
            while (true) {//i use an infinite loop because i have statements inside that will always be reached and end it.

                int[] result = num.ToString().Select(o => Convert.ToInt32(o) - '0').ToArray();
                num = 0;
                foreach (var item in result) {
                    num += item * item;
                }
                //Console.WriteLine(num);
                if (num == 89) {
                    return true;
                }
                if (num == 1) {
                    return false;
                }
            }
        }
    }
}
