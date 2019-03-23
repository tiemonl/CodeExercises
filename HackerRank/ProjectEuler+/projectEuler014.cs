using System;
using System.Collections.Generic;
using System.IO;
class Solution {
	private const int CACHE_SIZE = 5000000;
	private static int[] cache = new int[CACHE_SIZE + 1];
	private static int[] collatzCache = new int[CACHE_SIZE + 1];

	static void Main(String[] args) {

		precomputeCache();
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t; a0++) {
			int number = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(collatzCache[number]);
		}
	}

	private static void precomputeCache() {
		cache[0] = 1;
		cache[1] = 1;
		collatzCache[0] = 1;
		collatzCache[1] = 1;
		int maxSeq = 0;
		int maxNum = 0;
		for (int j = 2; j <= CACHE_SIZE; j++) {
			int collatzSeq = 0;
			long number = j;
			while (number > 1) {
				if (cache[j] > 0) {
					collatzSeq += cache[j];
					break;
				}
				collatzSeq++;
				if (number % 2 == 0) {
					number >>= 1;
				} else {
					number = 3 * number + 1;
				}
			}
			cache[j] = collatzSeq;
			if (collatzSeq >= maxSeq) {
				maxSeq = collatzSeq;
				maxNum = j;
			}
			collatzCache[j] = maxNum;
		}
	}
}