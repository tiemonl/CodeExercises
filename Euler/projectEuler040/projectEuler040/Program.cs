/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler040 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            string num = null;
            int total = 1;
            for (int i = 1; i < 200000; i++) {
                num += i;
                if (num.Length > 1000000)
                    break;
            }

            char[] numa = num.ToArray();
            for (int i = 0; i <= 6; i++) {
                total *= numa[(int)Math.Pow(10, i) - 1] - '0';
            }
            s.Stop();
            Console.WriteLine("total: {0}\nsolution took: {1} ms", total, s.ElapsedMilliseconds);
        }
    }
}
