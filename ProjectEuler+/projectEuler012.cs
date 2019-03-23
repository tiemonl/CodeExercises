using System;
using System.Collections.Generic;
using System.IO;
class Solution {
	static void Main(String[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t; a0++) {
			int n = Convert.ToInt32(Console.ReadLine());
			if (n == 2 || n == 3) {
				Console.WriteLine(6);
				continue;
			}
			int number = 1;
			int i = 2;
			int cnt = 0;
			int Dn1 = 2;
			int Dn = 2;
			int[] primelist = getPrimes(75000).ToArray();

			while (cnt <= n) {
				if (i % 2 == 0) {
					Dn = PrimeFactorisationNoD(i + 1, primelist);
					cnt = Dn * Dn1;
				} else {
					Dn1 = PrimeFactorisationNoD((i + 1) / 2, primelist);
					cnt = Dn * Dn1;
				}
				i++;
			}
			number = i * (i - 1) / 2;
			Console.WriteLine(number);
		}
	}
	public static int getFactors(int triNum) {
		int factors = 0;
		for (int i = 1; i <= Math.Sqrt(triNum); i++) {
			if (triNum % i == 0) {
				factors += 2;
			}
		}
		if (Math.Sqrt(triNum)* Math.Sqrt(triNum) == triNum) {
			--factors;
		}
		return factors;
	}

	private static int PrimeFactorisationNoD(int number, int[] primelist) {
		int nod = 1;
		int exponent;
		int remain = number;

		for (int i = 0; i < primelist.Length; i++) {

			// In case there is a remainder this is a prime factor as well
			// The exponent of that factor is 1
			if (primelist[i] * primelist[i] > number) {
				return nod * 2;
			}

			exponent = 1;
			while (remain % primelist[i] == 0) {
				exponent++;
				remain = remain / primelist[i];
			}
			nod *= exponent;

			//If there is no remainder, return the count
			if (remain == 1) {
				return nod;
			}
		}
		return nod;
	}
	public static List<int> getPrimes(int upperBound) {
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