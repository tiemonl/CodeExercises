using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        long[] primes = getPrimes(15486000).ToArray();
        long sum = 0;
        for (int i = 2; i < primes.Length; i++) {
            if (primes[i] == 1) {
                primes[i] = sum;
                continue;
            }
            sum += i;
            primes[i] = sum;
        }
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(primes[n]);
        }
    }
    static long[] getPrimes(int upperBound) {
        long[] numbers = new long[upperBound + 1];

        List<long> primes = new List<long>();
        for (int i = 2; i <= upperBound; ++i) {
            if (numbers[i] == 0) {
                primes.Add(i);
                numbers[i] = i;
                for (int j = 2 * i; j <= upperBound; j += i) {
                    numbers[j] = 1;
                }
            }
        }
        return numbers;
    }
}
