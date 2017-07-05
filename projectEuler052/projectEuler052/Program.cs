using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler052 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int answer = 0;
            for (int i = 1; i < int.MaxValue; i++) {
                //if (compare(i.ToString(), (i * 2).ToString())){
                //    if (compare(i.ToString(), (i * 3).ToString())){
                //        if (compare(i.ToString(), (i * 4).ToString())){
                //            if (compare(i.ToString(), (i * 5).ToString())){
                //                if (compare(i.ToString(), (i * 6).ToString())){
                //                    answer = i;
                //                    break;
                //                }
                //            }
                //        }
                //    }
                //}
                if (work(i)) {
                    answer = i;
                    break;
                }
            }
            s.Stop();
            Console.WriteLine("{0} can be multiplied by 1-6 and contain the same digits.\nSolution took: {1} ms", answer, s.ElapsedMilliseconds);
        }
        static bool work(int i) {
            for (int a = 2; a < 7; a++) {
                if (!compare(i.ToString(), (i * a).ToString()))
                    return false;
                else if (a == 6) {
                    return true;
                }
            }
            return false;
        }
        public static bool compare(string a, string b) {
            a = String.Concat(a.OrderBy(c => c));
            b = String.Concat(b.OrderBy(c => c));
            if (a == b) {
                return true;
            }
            return false;
        }
    }
}
