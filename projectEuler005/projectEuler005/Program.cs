using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler005 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int smallestNum = 0;
            for (int i = 2520; i < int.MaxValue; i+=20) {//i do 20 increments so it is always divisible by 20 and i can avoid checking the 19 in between.
                if (check(i) != 0) {
                    smallestNum = i;
                    break;
                }
            }
            s.Stop();
            Console.WriteLine("smallest prositve number that is evenly divisible by 1-20 is: {0}\nSolution took: {1} ms",smallestNum,s.Elapsed.TotalMilliseconds);
        }
        static public int check(int i) {
            for (int j = 19; j > 0; j--) {//i start at 19 because we are checking multiples of 20 so we know that 20 already works.
                if (i % j != 0) {
                    return 0;
                }
            }
            return i;
        }
    }
}
