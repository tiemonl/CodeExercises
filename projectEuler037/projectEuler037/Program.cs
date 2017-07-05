using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler037 {
    class Program {
        static Stopwatch s = Stopwatch.StartNew();
        static List<int> primes = ESieve(1000000);
        static List<char> invalidNums = new List<char>() { '1', '4', '6', '8', '9' };
        static void Main(string[] args) {
            int total = 0;
            int count = 0;
            foreach (var num in primes) {
                //int num = 3797;
                if (checkTrunk(num)) {
                    ++count;
                    total += num;
                    //Console.WriteLine(num + " is truncatable");
                }
                if (count == 11)
                    break;
            }
            s.Stop();
            Console.WriteLine("sum of the truncatable primes is: {0}\nsolution took: {1} ms", total, s.ElapsedMilliseconds);
        }
        static bool checkTrunk(int n) {
            string temp = n.ToString();
            if (n == 2 || n == 3 || n == 5 || n == 7) {
                return false;
            }
            if (invalidNums.Contains(temp[0]) || invalidNums.Contains(temp[temp.Length - 1])) {
                return false;
            }
            while (temp != "") {
                if (!primes.Contains(Convert.ToInt32(temp))) {
                    return false;
                }
                temp = temp.Remove(0, 1);
            }
            temp = n.ToString();
            while (temp != "") {
                if (!primes.Contains(Convert.ToInt32(temp))) {
                    return false;
                }
                temp = temp.Remove(temp.Length - 1);
            }
            return true;
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
