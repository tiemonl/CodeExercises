using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++) {
            int n = Convert.ToInt32(Console.ReadLine());
            double product = checkPythagorean(n);
            Console.WriteLine(product);
        }
    }
    public static double checkPythagorean(int n) {
        int largest = -1;
        for (int a = 3; a < n / 3; a++) {
            int c = (2 * a * (a - n) + n * n) / (2 * (n - a));
            int b = n - a - c;
            if (a * a + b * b == c * c && b > 0 && c > 0) {
                if (a * b * c > largest) {
                    largest = a * b * c;
                }
            }
        }
        return largest;
    }
}