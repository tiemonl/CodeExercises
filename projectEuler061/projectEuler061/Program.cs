/*Liam Tiemon*/

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectEuler061 {
    class Program {
        static int[] solution;
        static int[][] numbers;
        static void Main(string[] args) {
            //i had originally used code from my previous solutions to calculate all the numbers and solution, but afterwards i saw this solution which i felt was much better than mine and decided to use this instead as it ran much quicker and was much easier to understand than mine.
            Stopwatch s = Stopwatch.StartNew();
            int result = int.MaxValue;
            solution = new int[6];


            numbers = new int[6][];

            for (int i = 0; i < 6; i++) {
                numbers[i] = generateNumbers(i);
            }
            for (int i = 0; i < numbers[5].Length; i++) {
                solution[5] = numbers[5][i];
                if (FindNext(5, 1)) break;
            }
            result = solution.Sum();


            WriteStatus();
            Console.WriteLine("The sum of the series is {0}", result);
            s.Stop();
            Console.WriteLine("Solution took: {0} ms", s.ElapsedMilliseconds);
        }


        public static bool FindNext(int last, int length) {
            for (int i = 0; i < solution.Length; i++) {
                if (solution[i] != 0) continue;
                for (int j = 0; j < numbers[i].Length; j++) {

                    bool unique = true;
                    for (int k = 0; k < solution.Length; k++) {
                        if (numbers[i][j] == solution[k]) {
                            unique = false;
                            break;
                        }
                    }

                    if (unique && ((numbers[i][j] / 100) == (solution[last] % 100))) {
                        solution[i] = numbers[i][j];
                        if (length == 5) {
                            if (solution[5] / 100 == solution[i] % 100) return true;
                        }
                        if (FindNext(i, length + 1)) return true;
                    }
                }
                solution[i] = 0;
            }
            return false;
        }

        private static void WriteStatus() {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", solution[0], solution[1], solution[2], solution[3], solution[4], solution[5]);
        }
        public static int[] generateNumbers(int type) {

            List<int> numbers = new List<int>();

            int n = 0;
            int number = 0;

            while (number < 10000) {
                n++;
                switch (type) {

                    case 0:
                        //Triangle numbers
                        number = n * (n + 1) / 2;
                        break;
                    case 1:
                        // Square numbers
                        number = n * n;
                        break;
                    case 2:
                        // Pentagonal numbers
                        number = n * (3 * n - 1) / 2;
                        break;
                    case 3:
                        //Hexagonal numbers
                        number = n * (2 * n - 1);
                        break;
                    case 4:
                        //Heptagonal numbers
                        number = n * (5 * n - 3) / 2;
                        break;
                    case 5:
                        //Octagonal numbers
                        number = n * (3 * n - 2);
                        break;
                }
                if (number > 999)
                    numbers.Add(number);
            }

            return numbers.ToArray();
        }
    }
}
