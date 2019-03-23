using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            long sum = 0;
            long a = 1;
            long b = 1;
            while (b<n) {
                if (b % 2==0) {
                    sum += b;
                }
                long temp = b;
                b += a;
                a = temp;
            }
            Console.WriteLine(sum);
        }
    }
}