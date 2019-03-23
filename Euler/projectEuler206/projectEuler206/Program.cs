/*Liam Tiemon*/

using System;
using System.Numerics;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler206 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            long min = 1020304050607080900;
            long max = 1929394959697989990;
            long sqMin = (long)Math.Floor(Math.Sqrt(min));
            long sqMax = (long)Math.Floor(Math.Sqrt(max));
            Console.WriteLine(sqMax);
            Console.WriteLine(sqMin);
            Console.WriteLine(sqMax-sqMin);
            Console.WriteLine(Math.Pow(9, 9));
            for (long i = sqMax; i >= sqMin; i--) {
            //for (long i = sqMin; i < sqMax; i++) {
                BigInteger temp = i;
                BigInteger value = temp * temp;
                if (isMatch(value)) {
                    Console.WriteLine("Answer = " + temp + " is " + value);
                    break;
                } 
            }
            s.Stop();
            Console.WriteLine("solutiong took: {0} ms", s.ElapsedMilliseconds);
        }
        public static bool isMatch(BigInteger num) {
            bool isNum = ((num % 10) == 0);
            for (int i = 1; i < 10 && isNum; i++) {
                num /= 100;
                isNum = ((num % 10) == (10-i));
            }
            return isNum;
        }
    }
}
