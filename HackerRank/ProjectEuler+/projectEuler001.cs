using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
                long sum = 0;
                long three = (n - 1) / 3;
                long five = (n - 1) / 5;
                long fifteen = (n - 1) / 15;
                sum = 3 * (three * (three + 1) / 2) + 5 * (five * (five + 1) / 2) - 15 * (fifteen * (fifteen + 1) / 2);
                Console.WriteLine(sum);
        }
    }
}