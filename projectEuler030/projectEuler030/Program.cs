/*Liam Tiemon*/

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler030 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int sum = 0;
            int total = 0;
            for (int i = 2; i < 1000000; i++) {
                int[] num = i.ToString().Select(o => Convert.ToInt32(o) - '0').ToArray();
                for (int j = 0; j < num.Length; j++) {
                    sum += Convert.ToInt32(Math.Pow(num[j], 5));
                }
                if (sum == i) {
                    Console.WriteLine(i);
                    total += sum;
                }
                sum = 0;
            }
            s.Stop();
            Console.WriteLine("Total sum of all the valid digits: {0}\nSolution took {1} ms", total, s.Elapsed.TotalMilliseconds);
        }
    }
}
