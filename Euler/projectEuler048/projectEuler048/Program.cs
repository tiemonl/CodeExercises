/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler048 {
    class Program {
        static void Main(string[] args) {
            BigInteger num = 0;
            for (int i = 1; i < 1001; i++) {
                num += BigInteger.Pow(i, i);
            }
            char[] ten = num.ToString().ToCharArray();
            for (int i = ten.Length - 10; i < ten.Length; i++) {
                Console.Write(ten[i]);
            }
            Console.WriteLine();
        }
    }
}
