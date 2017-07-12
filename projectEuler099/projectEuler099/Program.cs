/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler099 {
    class Program {
        static void Main(string[] args) {
            //this is a working solution, however it takes way too long to get an answer and i have yet to find a solution that calculates number of 3+ million digits long quickly.
            //ill finish it later.
            BigInteger currentHigh = 0, high = 0;
            int lineNum = 0;
            int bestLine;
            StreamReader sr = new StreamReader("..\\..\\baseExp.txt");

            while (sr.Peek() >= 0) {
                lineNum++;
                string str;
                string[] strArray;
                str = sr.ReadLine();

                strArray = str.Split(',');
                int num = int.Parse(strArray[0]);
                int power = int.Parse(strArray[1]);
                Console.WriteLine(num);
                Console.WriteLine(power);
                high = BigInteger.Pow(num, power);
                if (currentHigh < high) {
                    currentHigh = high;
                    bestLine = lineNum;
                }
            }

            Console.WriteLine("line number: {0}", lineNum);
        }
    }
}
