using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler057 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            BigInteger temp = 1;
            BigInteger temp2 = 1;
            BigInteger numerator = 3;
            BigInteger denominator = 2;
            int counter = 0;
            //so for this one i found an interesting pattern for the numerator and denominator which made this program very easy to solve. 
            //the numerator follows this easy formula:
            //if a0 = 3, a1 = 7, a2 = 17, a3 = 41, a4 = 99 which were given values. as long as we know the previous value of the current value we can figure out the next value. 
            //in other words if we know x-1 and x, we can figure out x+1 without recursion. the pattern is 2x + (x-1), so multiply your current value by 2 and add the previous value to get the next value.
            //when you start off with a0 you dont know x-1, so x-1 is 1.
            //as far as the denominator goes, its just adding its current numerator to the denominator to get the next denominator;
            for (int i = 0; i < 1000; i++) {
                if (numerator.ToString().Length > denominator.ToString().Length) {
                    ++counter;
                }
                //Console.WriteLine("{0}/{1} {2} {3}",numerator,denominator,numerator.ToString().Length, denominator.ToString().Length);
                denominator = denominator + numerator;
                temp = numerator;
                numerator = 2 * numerator + temp2;
                temp2 = temp;

            }
            s.Stop();
            Console.WriteLine("There are {0} fractions containing a numerator with more digits than denominator\nSolution took: {1} ms", counter, s.ElapsedMilliseconds);
        }
    }
}
