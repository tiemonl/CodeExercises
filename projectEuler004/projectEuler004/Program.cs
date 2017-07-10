/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler004 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int largestPal = 0;
            for (int i = 999; i*i >= largestPal; i--) {
                for (int k = 999; k*k >= largestPal; k--) {
                    string num = (i*k).ToString();
                    string backwards = new string(num.Reverse().ToArray());
                    if (num.Equals(backwards)) {//check if the number is a palindrome by seeing if its equal its reverse.
                        if (i*k>largestPal) {//this keeps track of the largest palindrome.
                            largestPal = i * k;
                        }
                    }
                }
            }
            s.Stop();
            Console.WriteLine("Largest palindrome made from the product of two 3-digit numbers is: {0}\nSolution took: {1} ms",largestPal, s.Elapsed.TotalMilliseconds);
        }
    }
}
