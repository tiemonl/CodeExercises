using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler49
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch s = Stopwatch.StartNew();
            int[] primes = ESieve(9999);
            List<int> prime = primes.ToList();
            for (int i = 0; i < prime.Count; i++)
            {

                int j = 3330;
                if (prime.Contains(prime[i] + j))
                {
                    int num = prime[i] + j;
                    if (compare(prime[i].ToString(), num.ToString()) && prime.Contains(num + j))
                    {
                        if (compare(num.ToString(), (num + j).ToString()))
                            Console.WriteLine("{0} {1} {2}", prime[i], num, num + j);
                    }
                }
            }
            s.Stop();
            Console.WriteLine("Solution took: {0} ms", s.ElapsedMilliseconds);
        }

        public static bool compare(string a, string b)
        {
            a = String.Concat(a.OrderBy(c => c));
            b = String.Concat(b.OrderBy(c => c));
            if (a == b)
            {
                return true;
            }
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
