/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler009 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            double product = 1;
            for (int a = 1; a < 300; a++) {
                for (int b = a+1; b < 400; b++) {
                    //for (int c = b+1; c < 500; c++) { 

                    //getting rid of this loop made the solution over 220 times faster.
                    //c has to be a double so that it only whole numbers are seen as a valid pythagorean triplet, or else you get a false solution with int truncation.
                    double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                        if (/*Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == c && */a+b+c == 1000) {
                            product *= a * b * c;
                            break;
                        } 
                    //}
                }
            }
            Console.WriteLine(product);
            s.Stop();
            Console.WriteLine("solution took: {0} ms", s.Elapsed.TotalMilliseconds);
        }
    }
}
