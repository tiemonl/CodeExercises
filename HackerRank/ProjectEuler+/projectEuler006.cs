using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++) {
            int n = Convert.ToInt32(Console.ReadLine());
            long sumOfSq = 0;
            long sqOfSum = (n * (n + 1)) / 2;
            for (int i = 1; i <= n; i++) {
                sumOfSq += (int)Math.Pow(i, 2);
            }
            Console.WriteLine((sqOfSum * sqOfSum) - sumOfSq);
        }
    }
}