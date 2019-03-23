using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(primeCheck(n));
        }
    }
    public static long primeCheck (long n){
        int i;
        while (n % 2 == 0) n /= 2;
        if (n == 1) return 2;
        for (i = 3; i <= Math.Sqrt(n); i+=2) {
            while (n%i==0) {
                n /= i;
            }
        }
        if (n>2) {
            return n;
        } else {
            return i-2;
        }
    }
}