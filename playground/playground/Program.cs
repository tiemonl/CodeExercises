using System;
using System.Diagnostics;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playground {
    class Playground {
        static void Main(string[] args) {
            new Playground().listTest();
        }
        public void listTest() {
            List<BigInteger> list = new List<BigInteger>();
            BigInteger num = 0;
            for (int i = 1; i <= (int)Math.Pow(10,8); i++) {
                num = i * i;
                list.Add(num);
            }
            Console.WriteLine("done");
        }
    }
}
