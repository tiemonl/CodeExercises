using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler41
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = Stopwatch.StartNew();
            int[] primes = ESieve(1000000000);
            int answer =0;
            for (int i = primes.Length-1; i > 0; --i)
            {

                if (distinct(primes[i].ToString()) && hasN(primes[i].ToString()))
                {
                    answer = primes[i];
                    break;
                }
            }
            s.Stop();
            Console.WriteLine("largest pandigital prime making use of all the digits 1 to n: {0}\nSolution took: {1} ms", answer, s.ElapsedMilliseconds);
        }
        //this checks the length of a number and makes sure the number has the digits 1 to the length of the number.
        public static bool hasN(string a)
        {
            List<char> list = a.ToList();
            list.Sort();
            for (int i = 1; i <= a.Length; i++)
            {
                if (i != Convert.ToInt32(list[i-1])- '0')
                {
                    return false;
                }
            }
            return true;
        }
        public static bool distinct(string a)
        {
            if (a == null)
            {
                return false;
            }
            string b = RemoveDuplicates(a);
            if (a == b)
            {
                return true;
            }
            return false;
        }

        public static string RemoveDuplicates(string input)
        {
            return new string(input.ToCharArray().Distinct().ToArray());
        }

        static public int[] ESieve(int upperLimit)
        {
            int sieveBound = (int)(upperLimit - 1) / 2;
            int upperSqrt = ((int)Math.Sqrt(upperLimit) - 1) / 2;

            BitArray PrimeBits = new BitArray(sieveBound + 1, true);

            for (int i = 1; i <= upperSqrt; i++)
            {
                if (PrimeBits.Get(i))
                {
                    for (int j = i * 2 * (i + 1); j <= sieveBound; j += 2 * i + 1)
                    {
                        PrimeBits.Set(j, false);
                    }
                }
            }

            List<int> numbers = new List<int>((int)(upperLimit / (Math.Log(upperLimit) - 1.08366)));
            numbers.Add(2);

            for (int i = 1; i <= sieveBound; i++)
            {
                if (PrimeBits.Get(i))
                {
                    numbers.Add(2 * i + 1);
                }
            }

            return numbers.ToArray();
        }
    }
}
