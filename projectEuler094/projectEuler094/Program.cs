/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler094 {
    class Program {
        static void Main(string[] args) {

            //i first used the commented code below to find almost equilateral triangles, which worked until it lost precision after 10 triangles, so i used those values to find a pattern on https://oeis.org/ to calculate the answer.
            //i also noticed that the third side always rotates on whether to add or subtract from the equal sides;
            Stopwatch s = Stopwatch.StartNew();
            int[] a = new int[30];
            a[0] = 1;
            a[1] = 1;
            a[2] = 5;
            //for (int i = 3; i < a.Length; i++) {
            //    a[i] = 3 * a[i - 1] + 3 * a[i - 2] - a[i - 3];
            //}
            //this loop above calculates the side lengths where we add or subtract 1 to get the perimeter.
            double perimeters = 0;
            double side = 1;
            double m = 1;
            int n = 2;
            while (true) {
                side = a[n];
                n++;
                a[n] = 3 * a[n - 1] + 3 * a[n - 2] - a[n - 3];
                m = -m;
                if (perimeters + (3 * side) - m < Math.Pow(10,9)) {
                    perimeters += (3 * side) - m;
                } else {
                    break;
                }
                
            }
            Console.WriteLine(perimeters);
            s.Stop();
            Console.WriteLine("Solution took {0} ms", s.Elapsed.TotalMilliseconds);

            //double height;
            //double area;
            //double total = 0;
            //for (double a = 3; a < 1000000010; a += 2) {
            //    height = Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a + 1) / 2, 2));
            //    area = ((a + 1) / 2) * Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a + 1) / 2, 2));
            //    if (!area.ToString().Contains(".") && !height.ToString().Contains(".")) {
            //        Console.WriteLine("{0} * {1} = {2}\ttri={3} {4} {5}", (a + 1) / 2, height, area, a, a, a + 1);
            //        total += ((3 * a) + 1);
            //        Console.WriteLine(total);
            //    }
            //    height = Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a - 1) / 2, 2));
            //    area = ((a - 1) / 2) * Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a - 1) / 2, 2));
            //    if (!area.ToString().Contains(".") && !height.ToString().Contains(".")) {
            //        Console.WriteLine("{0} * {1} = {2}\ttri={3} {4} {5}", (a - 1) / 2, height, area, a, a, a - 1);
            //        total += ((3 * a) - 1);
            //        Console.WriteLine(total);
            //    }
            //    if ((3 * a) - 1 > 1000000000) {
            //        break;
            //    }
            //}
        }
    }
}
