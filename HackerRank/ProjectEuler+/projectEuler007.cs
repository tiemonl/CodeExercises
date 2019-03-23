using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[] primes = getPrimes(105000).ToArray();
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(primes[n-1]);
        }
    }
    static List<int> getPrimes(int upperBound) {
        int[] numbers = new int[upperBound + 1];

        List<int> primes = new List<int>();
        for (int i = 2; i <= upperBound; ++i) {
            if (numbers[i] == 0) {
                primes.Add(i);
                for (int j = 2 * i; j <= upperBound; j += i) {
                    numbers[j] = 1;
                }
            }
        }
        return primes;
    }
}