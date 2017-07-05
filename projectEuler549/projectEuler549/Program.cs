using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler549 {
    class Program {
        static int m =(int)Math.Pow(10, 8);
        static List<BigInteger> list = new List<BigInteger>();
        static void Main(string[] args) {
            BigInteger num = 2;
            BigInteger facts = 1;
            int total = 0;
            for (int i = 1; i <= 100000000; i++) {
                facts *= i;
                list.Add(facts);
            }
            Console.WriteLine("done");
            Console.WriteLine((double)GC.GetTotalMemory(true)/1024/1024/1024);
            Console.WriteLine(check(10007));
            for (int i =2; i <= m; i++) {
                total += check(i);
            }
            Console.WriteLine(total);
        }
        public static int check(int number) {

            try {
                for (int i = 0; i <= m; i++) {
                    if (list[i] % number == 0) {
                        return i + 1;
                    }
                }
            } catch (ArgumentOutOfRangeException) {
                Console.WriteLine(number);
                return 0 ;
            }

            return 0;
        }
    }
}
