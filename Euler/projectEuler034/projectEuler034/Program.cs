/*Liam Tiemon*/

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler034 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int[] factorials = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            int sum = 0;
            int total = 0;
            for (int i = 3; i < 999999; i++) {
                sum = 0;
                char[] num = i.ToString().ToCharArray();
                foreach (int item in num) {
                    sum += factorials[Convert.ToInt32(item) - '0'];
                }
                if (sum == i) {
                    Console.WriteLine(i);
                    total += i;
                }
            }
            s.Stop();
            Console.WriteLine("total sum of curious numbers: {0}\nSolution took {1} ms", total,s.Elapsed.TotalMilliseconds);
        }
    }
}
