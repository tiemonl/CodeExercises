using System;
using System.Numerics;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler120 {
    class Program {
        //[STAThread]
        static void Main(string[] args) {
            /*BigInteger total = 0;
            for (int i = 3; i < 1001; i++) {
                total += (int)Math.Pow(i, 2) - i;
            }
            Console.WriteLine(total);
            Clipboard.SetText(total.ToString());
            total = 0;
            for (BigInteger a = 3; a < 1001; a++) {
                //Console.WriteLine(a + "  " + BigInteger.Pow(a,2)+ "  " + remainder(a));
                total+=remainder(a);
            }
            Clipboard.SetText(total.ToString());
            Console.WriteLine(total);*/



            //after reading the analysis on https://projecteuler.net
            Console.WriteLine(remainderV2());
        }
        public static BigInteger remainder(BigInteger a) {
            BigInteger r = 0;
            for (int n = 1; n < 1501; n++) {
                BigInteger num = BigInteger.Pow(a - 1, n) + BigInteger.Pow(a + 1, n);
                BigInteger temp = num % BigInteger.Pow(a, 2);
                //Console.WriteLine("{0} % {1} = {2}",num, BigInteger.Pow(a, 2),temp);
                if (temp>r) {
                    r = temp;
                }
            }
            return r;
        }

        //this is a solution after i had originally solved it and read some analysis on https://projecteuler.net
        //with the analysis it shows that if a is even, Rmax is a^2 - 2a and when a is odd, Rmax is a^2 - a;
        public static int remainderV2() {
            int total=0;
            for (int a = 3; a < 1001; a++) {
                if (a%2==1) {
                    total += (int)Math.Pow(a, 2)-a;
                } else {
                    total+= (int)Math.Pow(a, 2) - (a*2);
                }
            }
            return total;
        }
    }
}
