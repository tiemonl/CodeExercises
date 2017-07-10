/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler069 {
    class Program {
        static void Main(string[] args) {
            double highest = 0;
            int highN = 0;
            for (int n = 2; n < 1000000; n++) {
                int phi = 1;
                //Console.Write(n + "; 1");
                for (int rp = 1; rp < n; rp++) {
                    if (n % rp == 0 || (n % 2 == 0 && rp % 2 == 0) || (n % 3 == 0 && rp % 3 == 0)) {
                        continue;
                    }
                    ++phi;

                }
                double answer = (double)n / phi;
                if (answer > highest) {
                    highest = answer;
                    highN = n;
                }
            }
            Console.WriteLine(highN + "////" + highest);

        }
    }
}
