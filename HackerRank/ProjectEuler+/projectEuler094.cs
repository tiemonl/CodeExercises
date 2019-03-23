using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long maxSide = Convert.ToInt64(Console.ReadLine());
            long[] a = new long[50];
            a[0] = 1;
            a[1] = 1;
            a[2] = 5;
			long perimeters = 0;
            long side = 1;
            long m = 1;
            int n = 2;
            while (true) {
                side = a[n];
                n++;
                a[n] = 3 * a[n - 1] + 3 * a[n - 2] - a[n - 3];
                m = -m;
                if ((3*side)-m <= maxSide) {
                    perimeters += (3 * side) - m;
                } else {
                    break;
                }
                
            }
            Console.WriteLine(perimeters);
        }
    }
}