using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler089 {
    class Program {
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            int originalTotal = 0, minTotal = 0;
            StreamReader sr = new StreamReader("..\\..\\roman.txt");

            while (sr.Peek() >= 0) {
                string str;
                str = sr.ReadLine();
                originalTotal += str.Length;
                if (str.Contains("VIIII")) {
                    str = str.Replace("VIIII", "IX");
                }
                if (str.Contains("IIII")) {
                    str = str.Replace("IIII", "IV");
                }
                if (str.Contains("LXXXX")) {
                    str = str.Replace("LXXXX", "XC");
                }
                if (str.Contains("XXXX")) {
                    str = str.Replace("XXXX", "XL");
                }
                if (str.Contains("DCCCC")) {
                    str = str.Replace("DCCCC", "CM");
                }
                if (str.Contains("CCCC")) {
                    str = str.Replace("CCCC", "CD");
                }
                minTotal += str.Length;
            }
            s.Stop();
            Console.WriteLine("number of chars saved by writing each number in their minimal form is {0}\nSolution took {1} ms",originalTotal -minTotal,s.Elapsed.TotalMilliseconds);
        }
    }
}
