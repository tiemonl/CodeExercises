using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler038 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            string answer = null;
            int highest = 0;
            for (int i = 1; i < 10000; i++) {
                answer = null;
                for (int j = 1; j <= 10; j++) {
                    answer += i * j;
                    if (distinct(answer) || answer.ToCharArray().Contains('0') || answer.Length == 9) {
                        break;
                    }

                }
                if (answer.Length == 9 && !distinct(answer) && !answer.ToCharArray().Contains('0') && Convert.ToInt32(answer) > highest)
                    highest = Convert.ToInt32(answer);

            }
            s.Stop();
            Console.WriteLine("Highest pandigital number is: {0}\nSolution took: {1} ms", highest, s.ElapsedMilliseconds);
        }
        public static bool distinct(string a) {
            if (a == null) {
                return false;
            }
            string b = RemoveDuplicates(a);
            if (a == b) {
                return false;
            }
            return true;
        }
        public static string RemoveDuplicates(string input) {
            return new string(input.ToCharArray().Distinct().ToArray());
        }
    }
}
