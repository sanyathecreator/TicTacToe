using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int move = 1;
        public int[] cells = new int[9];
        bool isGame = true;
        public Form1()
        {
            InitializeComponent();
        }

        public void SetSymbol(int[] array, int index)
        {
            if (array[index] == 0 && isGame)
            {
                if (move % 2 != 0)
                {
                    move++;
                    array[index] = 1;
                }
                else
                {
                    move++;
                    array[index] = -1;
                }
            }

        }

        public string DisplaySymbol(int[] array, int index)
        {
            if (array[index] == 1)
            {
                return "X";
            }
            else if (array[index] == -1)
            {
                return "O";
            }
            else
            {
                return "";
            }
        }

        public int CheckResult(int[] array)
        {
            int[][] winningCombinations = new int[][]
            {
                new int[] { 0, 1, 2 },
                new int[] { 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 0, 3, 6 },
                new int[] { 1, 4, 7 },
                new int[] { 2, 5, 8 },
                new int[] { 0, 4, 8 },
                new int[] { 2, 4, 6 },
            };

            foreach (int[] combination in winningCombinations)
            {
                if (array[combination[0]] == 1 && array[combination[1]] == 1 && array[combination[2]] == 1)
                {
                    return 1;
                }
                else if (array[combination[0]] == -1 && array[combination[1]] == -1 && array[combination[2]] == -1)
                {
                    return -1;
                }
            }

            return 0;
        }

        public void DisplayResult(int result)
        {
            if(result == 1)
            {
                isGame = false;
                label1.Text = "X wins";
            }
            else if(result == -1)
            {
                isGame = false;
                label1.Text = "O wins";
            }
        }

        public void CleanBoard(int[] array)
        {
            move = 1;

            foreach (var button in new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9 })
            {
                button.Text = "";
            }

            Array.Clear(array, 0, array.Length);
            label1.Text = "";
            isGame = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 0);
            button1.Text = DisplaySymbol(cells, 0);
            DisplayResult(CheckResult(cells));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 1);
            button2.Text = DisplaySymbol(cells, 1);
            DisplayResult(CheckResult(cells));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 2);
            button3.Text = DisplaySymbol(cells, 2);
            DisplayResult(CheckResult(cells));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 3);
            button4.Text = DisplaySymbol(cells, 3);
            DisplayResult(CheckResult(cells));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 4);
            button5.Text = DisplaySymbol(cells, 4);
            DisplayResult(CheckResult(cells));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 5);
            button6.Text = DisplaySymbol(cells, 5);
            DisplayResult(CheckResult(cells));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 6);
            button7.Text = DisplaySymbol(cells, 6);
            DisplayResult(CheckResult(cells));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 7);
            button8.Text = DisplaySymbol(cells, 7);
            DisplayResult(CheckResult(cells));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetSymbol(cells, 8);
            button9.Text = DisplaySymbol(cells, 8);
            DisplayResult(CheckResult(cells));
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            CleanBoard(cells);
        }
    }
}
