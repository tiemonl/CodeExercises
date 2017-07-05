using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudoku {
    class Program {
        private static SudokuGrid grid = new SudokuGrid();
        static void Main(string[] args) {
            grid.PopulateGrid();
            Console.WriteLine(grid.ToString());
            Console.WriteLine("Hit enter to solve");
            Console.Read();
            // Start Solving.
            grid.Solve();
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        public class SudokuGrid {

            private int[] vals = new int[81];
            public int this[int row, int column] {
                get { return vals[FindIndex(row, column)]; }
                set {
                    vals[FindIndex(row, column)] = value;
                }
            }
            public void PopulateGrid() {
                string str = "403020600900305001001806400008102900700000008006708200002609500800203009005010300";
                for (int i = 0; i < 81; i++) {
                    string s = str[i].ToString();
                    vals[i] = Int32.Parse(s);
                }
            }
            private int FindIndex(int row, int column) {
                return (((row - 1) * 9) + column - 1);
            }
            public override string ToString() {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                for (int row = 1; row <= 9; row++) {
                    for (int column = 1; column <= 9; column++) {
                        sb.Append(this[row, column] + " ");
                    }
                    sb.AppendLine();
                }
                return sb.ToString();
            }
            public void Solve() {
                for (int column = 1; column <= 9; column++) {
                    for (int row = 1; row <= 9; row++) {
                        if (TrySolving(row, column)) {
                            Console.Clear();
                            Console.WriteLine(this.ToString());
                            System.Threading.Thread.Sleep(150);
                            // restart
                            row = 1;
                            column = 1;
                        }
                    }
                }
            }
            private bool TrySolving(int row, int column) {
                List<RowColumnValue> possibleValuesFound = new List<RowColumnValue>();
                if (this[row, column] == 0) {
                    for (int possiblevalues = 1; possiblevalues <= 9; possiblevalues++) {
                        if (!DoesRowContainValue(possiblevalues, row, column)) {
                            if (!DoesColumnContainValue(possiblevalues, row, column)) {
                                if (!DoesSquareContainValue(possiblevalues, row, column)) {
                                    possibleValuesFound.Add(new RowColumnValue(row, column, possiblevalues));
                                }
                            }
                        }
                    }
                    if (possibleValuesFound.Count == 1) {
                        this[possibleValuesFound[0].Row, possibleValuesFound[0].Column] = possibleValuesFound[0].Value;
                        return true;
                    }
                }
                return false;
            }
            private bool DoesRowContainValue(int value, int row, int column) {
                for (int columnindex = 1; columnindex <= 9; columnindex++) {
                    if ((this[row, columnindex] == value) & column != columnindex) {
                        return true;
                    }
                }
                return false;
            }
            private bool DoesColumnContainValue(int value, int row, int column) {
                for (int rowindex = 1; rowindex <= 9; rowindex++) {
                    if ((this[rowindex, column] == value) & row != rowindex) {
                        return true;
                    }
                }
                return false;
            }
            private bool DoesSquareContainValue(int value, int row, int column) {
                //identify square
                int rowStart = ((row - 1) / 3) + 1;
                int columnStart = ((column - 1) / 3) + 1;
                int rowIndexEnd = rowStart * 3;
                if (rowIndexEnd == 0) rowIndexEnd = 3;
                int rowIndexStart = rowIndexEnd - 2;
                int columnIndexEnd = columnStart * 3;
                if (columnIndexEnd == 0) columnIndexEnd = 3;
                int columnIndexStart = columnIndexEnd - 2;
                for (int rowIndex = rowIndexStart; rowIndex <= rowIndexEnd; rowIndex++) {
                    for (int columnIndex = columnIndexStart; columnIndex <= columnIndexEnd; columnIndex++) {
                        if ((this[rowIndex, columnIndex] == value) & (columnIndex != column) & (rowIndex != row)) {
                            return true;
                        }
                    }
                }
                return false;
            }
        }
        internal class RowColumnValue {
            private int row;
            internal int Row {
                get { return row; }
            }
            private int column;
            internal int Column {
                get { return column; }
            }
            private int value;
            internal int Value {
                get { return value; }
            }
            internal RowColumnValue(int r, int c, int v) {
                row = r;
                column = c;
                value = v;
            }
        }
    }
}
