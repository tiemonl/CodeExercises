/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler043 {
    class Program {
        static int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static int[] div = new int[] { 2, 3, 5, 7, 11, 13, 17 };
        static List<string> pans = new List<string>();
        static List<double> sum = new List<double>();

        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            string result;
            int count = 1;
            int numPerm = 10 * 9 * 8 * 7 * 6 * 5 * 4 * 3 * 2;

            while (count < numPerm) {
                int N = perm.Length;
                int i = N - 1;

                while (perm[i - 1] >= perm[i]) {
                    i = i - 1;
                }

                int j = N;
                while (perm[j - 1] <= perm[i - 1]) {
                    j = j - 1;
                }

                // swap values at position i-1 and j-1
                swap(i - 1, j - 1);

                i++;
                j = N;

                while (i < j) {
                    swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                result = string.Join("", perm);
                pans.Add(result);
                count++;
            }

            foreach (var num in pans) {
                if (subDiv(num)) {
                    sum.Add(Convert.ToDouble(num));
                }
            }
            double total = 0;
            foreach (var item in sum) {
                total += item;
            }

            s.Stop();
            Console.WriteLine("The sum of pandigital numbers with the substring divisibility is: {0}", total);
            Console.WriteLine("Solution took {0} ms", s.ElapsedMilliseconds);
        }

        private static bool subDiv(string num) {
            for (int i = 1; i < num.Length - 2; i++) {
                int test = Convert.ToInt32(num.Substring(i, 3));
                if (!(test % div[i - 1] == 0))
                    return false;
            }
            return true;
        }

        private static void swap(int i, int j) {
            int k = perm[i];
            perm[i] = perm[j];
            perm[j] = k;
        }
    }
}
