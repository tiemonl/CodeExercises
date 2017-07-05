using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler033 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int numTotal = 1;
            int denTotal = 1;
            for (int num = 10; num < 99; num++) {
                for (int den = num + 1; den < 100; den++) {
                    List<char> nume = num.ToString().ToCharArray().ToList();
                    List<char> deno = den.ToString().ToCharArray().ToList();
                    foreach (var item in nume) {
                        if (deno.Contains(item) && !(item == '0')) {
                            nume.Remove(item);
                            deno.Remove(item);
                            if (checkSim(num, den, Convert.ToInt32(nume[0]) - '0', Convert.ToInt32(deno[0]) - '0')) {
                                numTotal *= num;
                                denTotal *= den;
                            }
                            break;
                        }
                    }
                }
            }
            s.Stop();
            Console.WriteLine("product of the curious fractions: {0}/{1}\nSolution took: {2} ms", numTotal / GCD(numTotal, denTotal), denTotal / GCD(numTotal, denTotal), s.Elapsed.TotalMilliseconds);
        }
        static bool checkSim(int a, int b, int c, int d) {
            try {
                decimal original = (decimal)a / b;
                decimal newValue = (decimal)c / d;
                if (original == newValue)
                    return true;
                return false;
            } catch (DivideByZeroException) {
                return false;
                throw;
            }
        }
        static int GCD(int a, int b) {
            while (b > 0) {
                int rem = a % b;
                a = b;
                b = rem;
            }
            return a;
        }
    }
}
