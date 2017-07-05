using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler44
{
    class Program
    {
        const int numPentagons = 2500;
        static void Main(string[] args)
        {
            List<int> pentagons = calcPentagons();

            for (int j = 0; j < pentagons.Count; j++)
            {
                for (int k = j+1; k < pentagons.Count; k++)
                {
                    int sumPent = pentagons[j] + pentagons[k];
                    int subPent = Math.Abs(pentagons[k] - pentagons[j]);
                    if (pentagons.Contains(sumPent) && pentagons.Contains(subPent))
                    {
                        Console.WriteLine("{0} + {1} = {2} which are all pentagonal", pentagons[j], pentagons[k], sumPent);
                        Console.WriteLine("{1} - {0} = {2} which are all pentagonal", pentagons[j], pentagons[k], subPent);
                        Console.WriteLine("j: {0}          k: {1}", j, k);
                        j = pentagons.Count;
                        break;
                    }
                }
            }
        }
        private static List<int> calcPentagons()
        {
            List<int> list = new List<int>();
            for (int i = 0; i < numPentagons; i++)
            {
                list.Add((i + 1) * ((3 * (i+1)) - 1) / 2);
            }
            return list;
        }
    }
}
