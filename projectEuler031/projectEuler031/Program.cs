/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler031 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();

            int target = 200;
            int total = 0;

            for (int a = target; a >= 0; a -= 200) {
                for (int b = a; b >= 0; b -= 100) {
                    for (int c = b; c >= 0; c -= 50) {
                        for (int d = c; d >= 0; d -= 20) {
                            for (int e = d; e >= 0; e -= 10) {
                                for (int f = e; f >= 0; f -= 5) {
                                    for (int g = f; g >= 0; g -= 2) {
                                        total++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("2 Pounds can be generated in {0} number of ways\nSolution took {1} ms", total, s.Elapsed.TotalMilliseconds);
        }
    }
}
