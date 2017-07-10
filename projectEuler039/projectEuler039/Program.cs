/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler039 {
    class Program {
        const int PERIMETER = 1000;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int longest = 0;
            int run = 0;
            int perimeter = 0;
            int last = int.MaxValue;
            List<int> list = new List<int>();
            for (int a = 1; a <= PERIMETER; a++) {
                for (int b = a; b <= PERIMETER; b++) {
                    for (int c = a + 1; c <= PERIMETER; c++) {
                        if (a + b + c <= PERIMETER) {
                            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) {
                                list.Add(a + b + c);
                            }
                        }
                    }
                }
            }
            list.Sort();
            foreach (var item in list) {
                if (item == last)
                    ++run;
                else
                    run = 0;
                if (run > longest) {
                    longest = run;
                    perimeter = item;
                }
                last = item;
            }
            s.Stop();
            Console.WriteLine("{0}\nsolution took: {1} ms", perimeter, s.ElapsedMilliseconds);
        }
    }
}
