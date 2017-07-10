/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler023 {
    class Program {
        static List<int> abundantNums = new List<int>();
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int answer = 0;


            for (int i = 0; i < 28123; i++) {
                checkAbundance(i);
            }
            Console.WriteLine("checkAbundance is done");
            int[] nums = abundantNums.ToArray();
            List<int> sums = new List<int>();
            for (int j = 0; j < nums.Length; j++) {
                for (int k = 0; k < nums.Length; k++) {
                    sums.Add(nums[j] + nums[k]);
                }
            }
            Console.WriteLine("all sums added.");
            Console.WriteLine("count before deleting duplicates: {0}", sums.Count);
            List<int> distinct = sums.Distinct().ToList();
            Console.WriteLine("count after duplicates removed: {0}", distinct.Count);

            List<int> noSum = new List<int>();
            for (int i = 0; i < 28123; i++) {
                if (!(distinct.Contains(i))) {
                    noSum.Add(i);
                }
                //Console.WriteLine(i);
            }
            Console.WriteLine("checked if no sum, now adding up the sum off all digits.");
            int[] noSums = noSum.ToArray();
            for (int i = 0; i < noSums.Length; i++) {
                answer += noSums[i];
            }
            Console.Clear();
            s.Stop();
            Console.WriteLine("sum of all the positive integers which cannot be written as the sum of two abundant numbers is: {0}\nSolution took: {1} ms", answer, s.Elapsed.TotalMilliseconds);
        }

        static void checkAbundance(int num) {
            int sum = 0;
            for (int i = 1; i < num; i++) {
                if (num % i == 0) {
                    sum += i;
                }
            }
            if (sum > num) {
                abundantNums.Add(num);
            }
        }
    }
}
