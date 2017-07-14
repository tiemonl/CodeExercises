/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler066 {
    class Program {
        const int limit = 1000;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            Console.WriteLine(Math.Log(64,2));
            int[] D = Enumerable.Range(2, limit).ToArray();
            int xMax = 0;
            int xMaxD = 0;
            for (int i = 0; i < 14; i++) {
                if (!Math.Sqrt(D[i]).ToString().Contains('.')) {
                    continue;
                }
                int x = diophantine(D[i]);
                //int x = Math.Sqrt(1 + D[i] * Math.Pow(D[i], 2));
                if (xMax < x) {
                    xMax = x;
                    xMaxD = D[i];
                }
            }
            Console.WriteLine(xMaxD + " " + xMax);
            s.Stop();
            Console.WriteLine("Solution took {0} ms",s.Elapsed.TotalMilliseconds);
        }

        public static int diophantine(int D) {
            for (int i = (int)Math.Ceiling(Math.Sqrt(D)); i < int.MaxValue; i++) {
                if (Math.Pow(i, 2) < D) {
                    continue;
                }
                if (((Math.Pow(i, 2) - 1) % D)!=0) {
                    continue;
                }
                if (Math.Sqrt(((Math.Pow(i, 2) - 1) / D)).ToString().Contains('.') ){
                    continue;
                } else {
                    return i;
                }
            }
            return 0;
        }
        }
}
