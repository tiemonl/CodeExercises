/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler036 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            List<int> palindromesTen = new List<int>();
            int sum = 0;
            for (int i = 0; i < 1000000; i++) {
                if (ReverseString(i.ToString()) == i.ToString()) {
                    palindromesTen.Add(i);
                }
            }
            foreach (var pal in palindromesTen) {
                string num = Convert.ToString(pal, 2);
                if (num == ReverseString(num)) {
                    //Console.WriteLine(Convert.ToString(Convert.ToInt32(num, 2), 10) + " " + num + " " + pal);
                    sum += pal;
                }
            }
            Console.WriteLine(sum);
            s.Stop();
            Console.WriteLine("Solution took: {0} ms", s.ElapsedMilliseconds);
        }
        public static string ReverseString(string s) {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
