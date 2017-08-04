using System;
using System.Numerics;
using System.Collections.Generic;
using System.IO;
class Solution {
	static void Main(String[] args) {
		/* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
		int t = Convert.ToInt32(Console.ReadLine());
		for (int a0 = 0; a0 < t; a0++) {
			long n = Convert.ToInt64(Console.ReadLine());

			Console.WriteLine(NumberToWords(n));
		}
	}
	public static string NumberToWords(long number) {
		if (number == 0)
			return "Zero";

		string words = "";

		if ((number / 1000000000) > 0) {
			words += NumberToWords(number / 1000000000) + " Billion ";
			number %= 1000000000;
		}

		if ((number / 1000000) > 0) {
			words += NumberToWords(number / 1000000) + " Million ";
			number %= 1000000;
		}

		if ((number / 1000) > 0) {
			words += NumberToWords(number / 1000) + " Thousand ";
			number %= 1000;
		}

		if ((number / 100) > 0) {
			words += NumberToWords(number / 100) + " Hundred ";
			number %= 100;
		}

		if (number > 0) {

			var unitsMap = new[] { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
			var tensMap = new[] { "Zero", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

			if (number < 20)
				words += unitsMap[number];
			else {
				words += tensMap[number / 10];
				if ((number % 10) > 0)
					words += " " + unitsMap[number % 10];
			}
		}

		return words;
	}
}