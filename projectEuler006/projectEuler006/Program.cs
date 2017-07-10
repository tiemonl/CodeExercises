/*Liam Tiemon*/

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler006 {
    class Program {
        const int numsToCheck = 100;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            double sumOfSq = 0;
            double SqOfSum = Math.Pow((numsToCheck*(numsToCheck+1))/2,2);//I use the formula (n(n+1))/2 to find the sum of the first n digits and square it instead of adding the first n digits manually.
            for (int i = 1; i <= numsToCheck; i++) {
                sumOfSq += (int)Math.Pow(i, 2);
            }
            s.Stop();
            Console.WriteLine("the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum is: {0}\nSolution took: {1} ms", (SqOfSum-sumOfSq), s.Elapsed.TotalMilliseconds);
        }
    }
}
