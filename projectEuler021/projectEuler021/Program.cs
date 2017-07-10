/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler021 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int total = 0;
            for (int i = 1; i < 10000; i++) {
                if (getFactors(getFactors(i))==i && getFactors(i)!=i) {
                    //the && part of the if statement is to make sure i get rid of perfect numbers as they are not amicable because amicable numbers cannot equal themselves.
                    total += i;
                }
            }
            Console.WriteLine(total);
            s.Stop();
            Console.WriteLine("solution took {0} ms", s.Elapsed.TotalMilliseconds);
        }
        public static int getFactors(int num) {
            int factors = 1;
            int sqrt = (int)Math.Sqrt(num);
            
            for (int i = 2; i < Math.Sqrt(num); i++) {
                if (num % i == 0) {
                    factors += i;
                    factors += (num / i);
                }
            }
            return factors;
        }
    }
}
