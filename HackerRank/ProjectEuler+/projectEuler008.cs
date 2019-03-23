using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++) {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string num = Console.ReadLine();
            long largestProduct = 0;
            for (int i = 0; i < n-k; i++) {
                long product = 1;
                for (int j = i; j < i+k; j++) {
                    product *= Convert.ToInt64(num[j] - '0');
                }
                if (largestProduct< product) {
                    largestProduct = product;
                }
            }
            Console.WriteLine(largestProduct);
        }
    }
}