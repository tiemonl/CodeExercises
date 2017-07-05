using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.IO;

namespace projectEuler99
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger currentHigh = 0, high = 0;
            int lineNum = 0;
            int bestLine;
            StreamReader sr = new StreamReader("C:\\tri.txt");
            
                while (sr.Peek() >= 0)
                {
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
                    if (currentHigh < high)
                    {
                        currentHigh = high;
                        bestLine = lineNum;
                    }
                }
            
            Console.WriteLine("line number: {0}", lineNum);
        }
    }
}
