using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler032 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            string a = null;
            int sum = 0;
            List<int> totals = new List<int>();
            for (int i = 1; i < 2500; i++) {

                for (int j = i; j < 2500; j++) {
                    a += i; a += j; a += (i * j);
                    if (distinct(a) && hasN(a) && a.Length == 9) {
                        //Console.WriteLine("{0} x {1} = {2} is pandigital.", i, j, i * j);
                        totals.Add(i * j);
                    }

                    a = null;
                }
            }

            foreach (var item in totals.Distinct().ToList()) {
                sum += item;
            }
            s.Stop();
            Console.WriteLine("sum of pandigital products: {0}\nsolution took: {1} ms", sum, s.Elapsed.TotalMilliseconds);
        }

        //this checks the length of a number and makes sure the number has the digits 1 to the length of the number.
        public static bool hasN(string a) {
            List<char> list = a.ToList();
            list.Sort();
            for (int i = 1; i <= a.Length; i++) {
                if (i != Convert.ToInt32(list[i - 1]) - '0') {
                    return false;
                }
            }
            return true;
        }

        public static bool distinct(string a) {
            if (a == null) {
                return false;
            }
            string b = RemoveDuplicates(a);
            if (a == b) {
                return true;
            }
            return false;
        }

        public static string RemoveDuplicates(string input) {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
    }
    }

