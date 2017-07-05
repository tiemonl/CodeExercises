using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler71 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            decimal currentHigh = 0;
            int highN = 0, highD = 0;
            for (int d = 1; d < 1000001; d++) {
                for (int n = ((d/7)*3)-1; n < d; n++) {
                    decimal current = (decimal)n / d;
                    //Console.WriteLine(current + " " + n + "/" + d);
                    if (current < (decimal)3/7 && current > currentHigh) {
                        currentHigh = (decimal)n / d;
                        highD = d;
                        highN = n;
                    }
                    if (current > currentHigh) {
                        break;
                    }
                }
            }
            s.Stop();
            Console.WriteLine("{0} {1} / {2}\nsolution took: {3} ms",currentHigh,highN,highD,s.ElapsedMilliseconds);
        }
    }
}
