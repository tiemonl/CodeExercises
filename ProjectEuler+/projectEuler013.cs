using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
class Solution {
	static void Main(String[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int n = Convert.ToInt32(Console.ReadLine());
		BigInteger sum = 0;
		for (int a0 = 0; a0 < n; a0++) {
			BigInteger num = BigInteger.Parse(Console.ReadLine());
			sum += num;
		}
		char[] nums = sum.ToString().ToCharArray();
		for (int i = 0; i < 10; i++) {//first ten digits
			Console.Write(nums[i]);
		}
	}
}