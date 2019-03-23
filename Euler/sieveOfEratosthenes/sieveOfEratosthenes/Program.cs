using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This sieve code (ESieve method) is courtesy of Kristian over at https://www.mathblog.dk
//I do not want to take any credit for this code as it has helped me a lot.
namespace sieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().call();
        }
        public void call()
        {
            List<int> primes = ESieve(1000000);
            foreach (var item in primes)
            {
                Console.WriteLine(item);
                //Console.ReadLine();

            }
        }
        public static List<int> ESieve(int upperLimit)
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

            return numbers;
        }
    }
}
