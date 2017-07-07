using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler019 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int year;
            int day;
            int week = 1;
            int sundays = 0;
            int[] months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (year = 1900; year < 2001; year++) {
                for (int i = 0; i < 12; i++) {
                    if (year % 4 == 0) {
                        months[1] = 29;
                    }
                    for (day = 1; day < months[i]; day++) {
                        week++;
                        if (week > 7)
                            week = 1;

                        if (day == 1 && week == 1)
                            if (year > 1900)
                                sundays++;
                    }
                }
                months[1] = 28;
            }
            Console.WriteLine(sundays);
            s.Stop();
            Console.WriteLine("Solution took {0} ms",s.Elapsed.TotalMilliseconds);
        }
    }
}
