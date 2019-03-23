/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler013 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            BigInteger sum=0;
            char[] nums;
            StreamReader sr = new StreamReader("..\\..\\num.txt");

            while (sr.Peek() >= 0) {
                sum += BigInteger.Parse(sr.ReadLine());
            }
            nums = sum.ToString().ToCharArray();
            for (int i = 0; i < 10; i++) {//first ten digits
                Console.Write(nums[i]);
            }
            s.Stop();
            Console.WriteLine("\nSolution took {0} ms",s.Elapsed.TotalMilliseconds);
        }
    }
}
