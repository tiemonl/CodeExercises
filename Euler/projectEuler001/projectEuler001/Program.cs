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
            int n = 1000;
            long sum = 0;
            long three = (n - 1) / 3;
            long five = (n - 1) / 5;
            long fifteen = (n - 1) / 15;
            sum = 3 * (three * (three + 1) / 2) + 5 * (five * (five + 1) / 2) - 15 * (fifteen * (fifteen + 1) / 2);
            s.Stop();
            Console.WriteLine("sum of all the multiples of 3 or 5 below 1000 is: {0}\nSolution took: {1} ms",sum,s.Elapsed.TotalMilliseconds);
        }
    }
}
