using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
class Solution {
	static void Main(String[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t; a0++) {
			int n = Convert.ToInt32(Console.ReadLine());
			BigInteger num = BigInteger.Pow(2, n);
			int sum = 0;
			foreach (var item in num.ToString()) {
				sum += int.Parse(item.ToString());
			}
			Console.WriteLine(sum);
		}
	}
}