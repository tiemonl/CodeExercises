/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler094 {
    class Program {
        static void Main(string[] args) {

            //i first used the commented code below to find almost equilateral triangles, which worked until it lost precision, so i used those values to find a pattern on https://oeis.org/ to calculate the answer.
            //i also noticed that the third side always rotates on whether to add or subtract from the equal sides;
            int[] a = new int[30];
            a[0] = 1;
            a[1] = 1;
            a[2] = 5;
            for (int i = 3; i < a.Length; i++) {
                a[i] = 3 * a[i - 1] + 3 * a[i - 2] - a[i - 3];
            }
            //this loop above calculates the side lengths where we add or subtract 1 to get the perimeter.
            double perimeters = 0;
            double side = 1;
            double m = 1;
            int n = 2;
            while (perimeters < Math.Pow(10,9)) {
                side = a[n];
                n++;
                m = -m;
                perimeters += (3 * side) - m;
            }
            perimeters -= (3 * side) - m;
            Console.WriteLine(perimeters);

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
