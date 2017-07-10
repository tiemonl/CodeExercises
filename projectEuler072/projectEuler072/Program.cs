/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler072 {
    class Program {
        static void Main(string[] args) {
            //at first i tried to just go through each possibility and divide and count how many unique answers there are by storing them in a set.
            //then i just decided to see if there was a GCD and if there wasn't, add one to a counter, but going through every possibility takes a while.
            //still trying to figure out a faster way of doing this.


            //SortedSet<decimal> ss = new SortedSet<decimal>();
            int s = 0;
            for (int d = 2; d <= 1000000; d++) {
                for (int n = 1; n < d; n++) {
                    //ss.Add((decimal)n / d);
                    if (GCD(n, d) == 1) {
                        s++;
                    }
                }
            }
            Console.WriteLine(s);
        }
        static int GCD(int a, int b) {
            return b == 0 ? a : GCD(b, a % b);
        }
    }
}
