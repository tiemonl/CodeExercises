﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler24
{
    class Program
    {
        static int[] perm = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        
        static void Main(string[] args)
        {

            Stopwatch clock = Stopwatch.StartNew();

            int count = 1;
            int numPerm = 10000000;

            while (count < numPerm)
            {
                int N = perm.Length;
                int i = N - 1;

                while (perm[i - 1] >= perm[i])
                {
                    i = i - 1;
                }

                int j = N;
                while (perm[j - 1] <= perm[i - 1])
                {
                    j = j - 1;
                }

                // swap values at position i-1 and j-1
                swap(i - 1, j - 1);

                i++;
                j = N;

                while (i < j)
                {
                    swap(i - 1, j - 1);
                    i++;
                    j--;
                }
                count++;
            }

            string permNum = "";
            for (int k = 0; k < perm.Length; k++)
            {
                permNum = permNum + perm[k];
            }


            clock.Stop();
            Console.WriteLine("The millionth lexicographic permutation is: {0}", permNum);
            Console.WriteLine("Solution took {0} ms", clock.ElapsedMilliseconds);
        }

        private static void swap(int i, int j)
        {
            int k = perm[i];
            perm[i] = perm[j];
            perm[j] = k;
        }

    }
}
