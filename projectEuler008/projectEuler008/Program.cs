using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler008 {
    class Program {
        const int SEQUENCE_LENGTH = 13;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();

            long total = 1;
            long highTotal = 1;
            List<long> nums = new List<long>();
            StreamReader sr = new StreamReader("..\\..\\num.txt");

            while (sr.Peek() >= 0) {
                string str = sr.ReadLine();
                foreach (var item in str.ToCharArray()) {
                    nums.Add(long.Parse(item.ToString()));
                }
            }
            for (int i = 0; i < nums.Count-SEQUENCE_LENGTH; i++) {
                total = 1;
                for (int j = i; j < i+SEQUENCE_LENGTH; j++) {
                    total *= nums[j];
                }
                if (highTotal<total) {
                    highTotal = total;
                }
            }
            Console.WriteLine(highTotal);
            s.Stop();
            Console.WriteLine("solution took {0} ms", s.Elapsed.TotalMilliseconds);
        }
    }
}
