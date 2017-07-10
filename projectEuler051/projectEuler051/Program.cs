/*Liam Tiemon*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler051 {
    class Program {

        static List<int> primeList;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            primeList = ESieve(1000000);
            int targetReplacements = 8;
            int smallest = 0;
            int digit1 = 0, digit2 = 0, digit3 = 0;
            foreach (int prime in primeList) {

                if (tripleReplacement(prime, out digit1, out digit2, out digit3) >= targetReplacements) {
                    smallest = prime;
                    break;
                }

            }
            s.Stop();
            Console.WriteLine("smallest prime replacement with {1} possible values is {2}, by replacing the {3}, {4}, and {5} digits\nsolution took: {0} ms", s.ElapsedMilliseconds, targetReplacements, smallest, digit1 + 1, digit2 + 1, digit3 + 1);
        }

        public static int replacement(int num) {
            int count = 0;
            int highest = 0;
            string number = num.ToString();
            int test;
            for (int i = 0; i < number.Length; i++) {
                count = 0;
                for (int j = 0; j < 10; j++) {

                    if (i == 0 && j == 0) {
                        j++;
                    }
                    char[] chars = number.ToCharArray();

                    char newChar = (char)(j + 48);
                    chars[i] = newChar;
                    string temp = new string(chars);
                    test = Convert.ToInt32(temp);
                    Console.WriteLine(test);
                    if (primeList.Contains(test) && test > 10) {
                        count++;
                    }
                    number = num.ToString();
                }
                if (count > highest) {
                    highest = count;
                }
            }
            return highest;
        }

        public static int doubleReplacement(int num, out int digit1, out int digit2) {
            int count = 0;
            int highest = 0;
            string number = num.ToString();
            int test;
            digit1 = 0;
            digit2 = 0;
            for (int i = 0; i < number.Length; i++) {
                for (int k = i; k < number.Length; k++) {
                    count = 0;
                    for (int j = 0; j < 10; j++) {
                        if (i == 0 && j == 0) {
                            j++;
                        }
                        char[] chars = number.ToCharArray();
                        char newChar = (char)(j + 48);
                        chars[i] = newChar;
                        chars[k] = newChar;
                        string temp = new string(chars);
                        test = Convert.ToInt32(temp);
                        //Console.WriteLine(test);
                        if (primeList.Contains(test) && test > 10) {
                            count++;
                        }
                        number = num.ToString();
                    }
                    if (count > highest) {
                        highest = count;
                        digit1 = i;
                        digit2 = k;
                    }
                }
            }
            return highest;
        }

        public static int tripleReplacement(int num, out int digit1, out int digit2, out int digit3) {
            int count = 0;
            int highest = 0;
            string number = num.ToString();
            int test;
            digit1 = digit2 = digit3 = 0;
            for (int a = 0; a < number.Length; a++) {
                for (int b = a + 1; b < number.Length; b++) {
                    for (int c = b + 1; c < number.Length; c++) {
                        count = 0;
                        for (int j = 0; j < 10; j++) {
                            if (a == 0 && j == 0) {
                                j++;
                            }
                            char[] chars = number.ToCharArray();
                            if (chars[a] == chars[b] && chars[a] == chars[c]) {

                                char newChar = (char)(j + 48);
                                chars[a] = newChar;
                                chars[b] = newChar;
                                chars[c] = newChar;
                                string temp = new string(chars);
                                test = Convert.ToInt32(temp);

                                if (primeList.Contains(test) && test > 10) {
                                    //Console.WriteLine(test);
                                    count++;
                                }
                                number = num.ToString();
                            }
                        }

                        if (count > highest) {
                            highest = count;
                            digit1 = a;
                            digit2 = b;
                            digit3 = c;
                        }
                    }
                }
            }
            return highest;
        }

        public static List<int> ESieve(int upperLimit) {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++) {
                if (PrimeBits.Get(i)) {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1) {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++) {
                if (PrimeBits.Get(i)) {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers;
        }
    }
}
