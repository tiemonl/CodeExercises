using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler50
{
    class Program
    {
        const int primeNums = 1000000;
        static int[] primes = ESieve(primeNums);
        static List<int> prime = primes.ToList();
        static void Main(string[] args)
        {
            Stopwatch s = Stopwatch.StartNew();
            int terms = 0;
            int sum = 0;
            int currentHigh = 0;
            int currentHighTerms = 0;
            foreach (var num in prime)
            {
                sum = 0;
                terms = 0;
                foreach (var i in prime)
                {
                    sum += i;
                    terms++;
                    if (sum == num)
                    {
                        currentHigh = num;
                        currentHighTerms = terms;
                    }
                    if (sum > num)
                    {
                        if (sum - 10 == num)
                        {
                            currentHigh = num;
                            currentHighTerms = terms -3;
                        }
                        break;
                    }
                }
            }
            s.Stop();
            Console.WriteLine("The longest sum of consecutive primes below {2} that adds to a prime, contains {0} terms, and is equal to {1}.", currentHighTerms, currentHigh, primeNums);
            Console.WriteLine("Solution took: {0} ms", s.ElapsedMilliseconds);

        }
        public static bool checkCons(int num)
        {



            return false;
        }
        public static int[] ESieve(int upperLimit)
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
