/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler001 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int sum = 0;
            for (int i = 0; i < 1000; i++) {
                if (i % 5 == 0 || i % 3 ==0) {
                    sum += i;
                }
            }
            s.Stop();
            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000 is: {0}\nSolution took: {1} ms",sum,s.Elapsed.TotalMilliseconds);
        }
    }
}
