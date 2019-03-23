using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++) {
            int n = Convert.ToInt32(Console.ReadLine());
            int smallestNum = 0;
            for (int i = 1; i < int.MaxValue; ++i) {
                if (check(i, n) != 0) {
                    smallestNum = i;
                    break;
                }
            }
            Console.WriteLine(smallestNum);
        }
    }
    static public int check(int i, int n) {
        for (int j = n; j > 0; j--) {
            if (i % j != 0) {
                return 0;
            }
        }
        return i;
    }
}