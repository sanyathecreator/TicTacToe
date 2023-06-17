using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public int move = 1;
        public Form1()
        {
            InitializeComponent();
        }

        string DisplaySymbol()
        {
            if (move % 2 != 0)
            {
                move++;
                return "X";
            }
            else
            {
                move++;
                return "O";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = DisplaySymbol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = DisplaySymbol();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = DisplaySymbol();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = DisplaySymbol();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = DisplaySymbol();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = DisplaySymbol();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = DisplaySymbol();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = DisplaySymbol();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = DisplaySymbol();
        }
    }
}
