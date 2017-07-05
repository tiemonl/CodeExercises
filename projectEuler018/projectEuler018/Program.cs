using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler018 {
    class Program {
        static void Main(string[] args) {
            var s = new Stopwatch();
            s.Start();
            int[][] nums = File.ReadAllLines("..\\..\\tri.txt")
                   .Select(l => l.Split(' ').Select(i => int.Parse(i)).ToArray())
                   .ToArray();

            //I'm going from the bottom of the pyramid adding the two childs to the parent node and seeing which addition gave the lower value, from there i save the higher value and go to the next set until i finish the row and move up a row until i reach the top which will give me my maximum number.
            for (int i = nums.Length - 1; i > 0; --i) {
                for (int j = 1; j < nums[i].Length; j++) {
                    if (nums[i][j - 1] > nums[i][j])
                        nums[i - 1][j - 1] += nums[i][j - 1];
                    else
                        nums[i - 1][j - 1] += nums[i][j];
                }
            }
            s.Stop();
            Console.WriteLine("Maximum total going down the pyramid is: {0}\nSolution took: {1} ms",nums[0][0],s.Elapsed.TotalMilliseconds);
        }
    }
}
