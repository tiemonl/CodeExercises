using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuSolver {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            setUp();
        }
        public void setUp() {
            Label[,] labels = new Label[9, 9];
            char[,] sudokuTable = new char[9, 9] {{'0','0','0','0','0','0','0','8','5' },
{ '0','0','0','2','1','0','0','0','9' },
{ '9','6','0','0','8','0','1','0','0' },
{ '5','0','0','8','0','0','0','1','6' },
{ '0','0','0','0','0','0','0','0','0'},
{ '8','9','0','0','0','6','0','0','7'},
{ '0','0','9','0','7','0','0','5','2'},
{ '3','0','0','0','5','4','0','0','0'},
{ '4','8','0','0','0','0','0','0','0'}};
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    labels[i, j] = new Label();
                    labels[i, j].Size = new Size(50, 50);
                    labels[i, j].Location = new Point(i * 50, j * 50);
                    labels[i, j].BackColor = Color.AliceBlue;
                    labels[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    labels[i, j].Font = new Font("Arial", 24, FontStyle.Bold);
                    labels[i, j].BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    if (sudokuTable[j, i] != '0') {
                        labels[i, j].Text = sudokuTable[j, i].ToString();
                    }
                    Controls.Add(labels[i, j]);
                    Console.WriteLine("row: {0} col: {1}", i, j);
                    //Console.ReadLine();
                }
            }
        }

        private void Form1_Click(object sender, EventArgs e) {
            Console.WriteLine("Mouse clicked");
        }
    }
}
