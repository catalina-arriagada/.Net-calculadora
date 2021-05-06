using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_1
{
    public partial class Form1 : Form
    {
        double first;
        double second;
        double outcome;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            txtOutcome.Text = txtOutcome.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text  + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + "0";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            txtOutcome.Text = txtOutcome.Text + ".";
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            operation = "+";
            first = double.Parse(txtOutcome.Text);
            txtOutcome.Clear();
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            operation = "-";
            first = double.Parse(txtOutcome.Text);
            txtOutcome.Clear();
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            operation = "*";
            first = double.Parse(txtOutcome.Text);
            txtOutcome.Clear();
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            operation = "/";
            first = double.Parse(txtOutcome.Text);
            txtOutcome.Clear();
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            second = double.Parse(txtOutcome.Text);

            switch (operation){
                case "+":
                    outcome = first + second;
                    txtOutcome.Text = outcome.ToString();

                    break;

                case "-":
                    outcome = first - second;
                    txtOutcome.Text = outcome.ToString();

                    break;

                case "*":
                    outcome = first * second;
                    txtOutcome.Text = outcome.ToString();

                    break;

                case "/":
                    outcome = first / second;
                    txtOutcome.Text = outcome.ToString();

                    break;

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            txtOutcome.Clear();
        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            txtOutcome.Clear();
        }
    }
}