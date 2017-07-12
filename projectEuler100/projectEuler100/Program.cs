/*Liam Tiemon*/

using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler100 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            if (count(out long blue, out long total)) {
                Console.WriteLine("blue disks: {0}\ttotal disks: {1}", blue, total);
            }
            s.Stop();
            Console.WriteLine("solution took: {0} ms",s.Elapsed.TotalMilliseconds);
        }
        public static bool probability(long red, long blue) {
            double first = (double)blue * (blue - 1);
            double second = (double)(blue + red) * (blue + red - 1);
            double answer = first / second;
            if (answer == .5) {
                return true;
            }
            return false;
        }
        public static bool count(out long blue, out long total) {
            blue = 0;
            total = 0;
            long blue1 = 3;
            long blue2 = 15;
            long red1 = 1;
            long red2 = 6;
            Console.WriteLine("blue disks: {0,-12}\tred disks: {1}", blue2, red2);
            while (blue2 + red2 < Math.Pow(10, 12)) {
                
                long temp = blue2;
                blue2 = (blue2*6) - blue1 - 2;
                blue1 = temp;
                temp = red2;
                red2 = (red2*6) - red1;
                red1 = temp;
                Console.WriteLine("blue disks: {0,-12}\tred disks: {1}", blue2, red2);
                if (blue2 + red2 > Math.Pow(10, 12)) {
                    blue = blue2;
                    total = blue2 + red2;
                    return true;
                }
            }
            return false;
        }
    }
}
