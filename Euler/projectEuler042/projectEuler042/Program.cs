/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler042 {
    class Program {
        const int NUM = 500;
        static void Main(string[] args) {
            Stopwatch s = Stopwatch.StartNew();
            string[] names = readInput("..\\..\\words.txt");
            List<BigInteger> tri = calcTriangles();
            int totalTri = 0;

            foreach (var item in names) {
                //string item = "SKY";
                char[] name = item.ToCharArray();
                int triNum = 0;
                for (int i = 0; i < name.Length; i++) {
                    //Console.WriteLine(name[i].ToString() + " " + (Convert.ToInt32(name[i])-64));
                    triNum += Convert.ToInt32(name[i]) - 64;
                }
                if (tri.Contains(triNum)) {
                    totalTri++;
                }
            }
            s.Stop();
            Console.WriteLine("total triangle numbers = {0}\nSolution took: {1} ms", totalTri, s.ElapsedMilliseconds);
        }
        private static List<BigInteger> calcTriangles() {
            List<BigInteger> list = new List<BigInteger>();
            for (BigInteger i = 0; i < NUM; i++) {
                list.Add((i + 1) * ((i + 1) + 1) / 2);
            }
            return list;
        }
        static private string[] readInput(string filename) {
            StreamReader r = new StreamReader(filename);
            string line = r.ReadToEnd();
            r.Close();

            string[] names = line.Split(',');

            for (int i = 0; i < names.Length; i++) {
                names[i] = names[i].Trim('"');
            }

            return names;
        }
    }
}
