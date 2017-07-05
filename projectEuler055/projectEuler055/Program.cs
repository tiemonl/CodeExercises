using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler055 {
    class Program {
            static void Main(string[] args)
            {
                Stopwatch s = Stopwatch.StartNew();
                int count = 0;
                for (BigInteger i = 1; i < 10000; i++) {
                    if (lychrel(i)) {
                        ++count;
                    }
                }
                s.Stop();
                Console.WriteLine("There are {0} Lychrel numbers\nSolution took: {1} ms", count, s.ElapsedMilliseconds);

            }
            public static string ReverseString(string s)
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
            public static bool lychrel(BigInteger num)
            {
                //start before the loop so that palindromic numbers have the oppurtunity to add once.
                int count = 1;
                num = num + BigInteger.Parse(ReverseString(num.ToString()));
                while (num.ToString() != ReverseString(num.ToString())) {
                    //Console.WriteLine(num + " + " + ReverseString(num.ToString()) + " = " + (num + BigInteger.Parse(ReverseString(num.ToString()))));
                    num = num + BigInteger.Parse(ReverseString(num.ToString()));
                    ++count;
                    if (count >= 50) {
                        return true;
                    }
                }
                return false;
            }
        }
}
