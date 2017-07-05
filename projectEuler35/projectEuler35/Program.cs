using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler35
{
    class Program
    {
        List<int> prime;
        List<int> checkd = new List<int>();
        static void Main(string[] args)
        {
            new Program().call();
        }
        public void call()
        {
            int[] primes = ESieve(1000000);
            prime = primes.ToList();
            Stopwatch s = Stopwatch.StartNew();
            foreach (var i in prime)
            {
                if (!checkd.Contains(i))
                {
                    checkCircular(i.ToString().ToCharArray());
                }
            }
            s.Stop();
            Console.WriteLine("total number of circular numbers: {0}.\nThis took a total of {1} ms.", checkd.Count, s.ElapsedMilliseconds);
        }
        public bool checkCircular(char[] num)
        {
            var nums = new Queue(num);
            string number = null;
            for (int i = 0; i < nums.Count; i++)
            {
                number = null;
                var check = nums.ToArray();
                for (int j = 0; j < check.Length; j++)
                {
                    number += check[j];
                }
                if (!prime.Contains(Convert.ToInt32(number)))
                {
                    return false;
                }
                nums.Enqueue(nums.Dequeue());
            }
            addToCheckd(num);
            return true;
        }
        public void addToCheckd(char[] num)
        {
            string number = null;
            var nums = new Queue(num);
            for (int i = 0; i < nums.Count; i++)
            {
                number = null;
                var check = nums.ToArray();
                for (int j = 0; j < check.Length; j++)
                {
                    number += check[j];
                }
                //Console.WriteLine(number);
                if (!checkd.Contains(Convert.ToInt32(number)))
                    checkd.Add(Convert.ToInt32(number));
                nums.Enqueue(nums.Dequeue());
            }
        }
        public int[] ESieve(int upperLimit)
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
