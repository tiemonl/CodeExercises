using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler22
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = readInput("C:\\Users\\ljtiemon\\Desktop\\names.txt");
            int sumResult = 0;

            Array.Sort(names);


            for (int i = 0; i < names.Length; i++)
            {
                //Console.WriteLine(names[i]);
                sumResult += (i + 1) * sum(names[i]);
            }
            Console.WriteLine("The total sum of the array alphabetically was {0}",sumResult);
        }

        static private int sum(string name)
        {
            int result = 0;
            for (int i = 0; i < name.Length; i++)
            {
                result += Convert.ToInt32(name[i]) - 64;
            }
            return result;
        }

        static private string[] readInput(string filename)
        {
            StreamReader r = new StreamReader(filename);
            string line = r.ReadToEnd();
            r.Close();

            string[] names = line.Split(',');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].Trim('"');
            }

            return names;
        }
    }
}
