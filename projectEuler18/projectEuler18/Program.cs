using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler18
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            int[][] nums = File.ReadAllLines("C:\\tri.txt")
                   .Select(l => l.Split(' ').Select(i => int.Parse(i)).ToArray())
                   .ToArray();
            //Console.WriteLine(nums.Length);
            //Console.WriteLine(nums[0].Length);
            for (int i = nums.Length-1; i > 0; --i)
            {
                for (int j = 1; j < nums[i].Length; j++)
                {
                    if (nums[i][j-1] > nums[i][j])
                        nums[i - 1][j-1] += nums[i][j - 1];
                    else
                        nums[i - 1][j - 1] += nums[i][j];
                    //Console.WriteLine(nums[i - 1][j-1]);
                }
               // Console.WriteLine("\n\n");
            }
            Console.WriteLine(nums[0][0]);
            s.Stop();
            Console.WriteLine(s.Elapsed);
        }
    }
}