using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler92 {
    class Program {
        static void Main(string[] args) {
            int counter = 0;
            for (int i = 2; i < 10000000; i++) {
                if (check(i)) {
                    ++counter;
                }
                //Console.WriteLine(i);
            }
            Console.WriteLine(counter);
        }
        static bool check(int n) {
            int num = n;
            while (true) {

                int[] result = num.ToString().Select(o => Convert.ToInt32(o) - '0').ToArray();
                num = 0;
                foreach (var item in result) {
                    num += item * item;
                }
                //Console.WriteLine(num);
                if (num == 89) {
                    return true;
                }
                if (num == 1) {
                    return false;
                }
            }
            return false;
        }
    }
}
