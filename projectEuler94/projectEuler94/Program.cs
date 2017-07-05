using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler94 {
    class Program {
        static void Main(string[] args) {
            double height;
            double area;
            double total = 0;
            for (double a = 3; a < 1000000010; a+=2) {
                height = Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a+1)/2, 2));
                area = ((a + 1) / 2) * Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a + 1) / 2, 2));
                if (!area.ToString().Contains(".") && !height.ToString().Contains(".")) {
                    Console.WriteLine("{0} * {1} = {2}\ttri={3} {4} {5}",(a+1)/2,height,area,a, a,a+1);
                    total += a + a + a + 1;
                    Console.WriteLine(total);
                }
                height = Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a - 1) / 2, 2));
                area = ((a - 1) / 2) * Math.Sqrt(Math.Pow(a, 2) - Math.Pow((a - 1) / 2, 2));
                if (!area.ToString().Contains(".") && !height.ToString().Contains(".")) {
                    Console.WriteLine("{0} * {1} = {2}\ttri={3} {4} {5}", (a - 1) / 2, height, area, a, a, a - 1);
                    total += a + a + a - 1;
                    Console.WriteLine(total);
                }
                if ((3*a)-1 >1000000000) {
                    break;
                }
            }
        }
    }
}
