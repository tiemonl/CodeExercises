using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler002 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int sum = 0;
            int a = 1;
            int b = 1;
            while (b<4000000) {
                int temp = b;
                b += a;
                a = temp;
                if (b % 2==0) {
                    sum += b;
                }
            }
            s.Stop();
            Console.WriteLine("Sum of even fibonacci numbers less than 4.000.000 is: {0}\nSolution took: {1} ms",sum, s.Elapsed.TotalMilliseconds);
        }
    }
}
