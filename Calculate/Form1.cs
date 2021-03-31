using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Form1 : Form
    {
        string _tmp;
        char act;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxInput(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                if (textBox1.TextLength == 0)
                {
                    textBox1.Text = "0";
                }
            }



        }

        private void NumericButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox1.Text == "0"&&button.Text!=",")
            {
                textBox1.Text = "";
            }
       
            if (textBox1.Text.IndexOf(',')== textBox1.Text.LastIndexOf(',')&& textBox1.Text.LastIndexOf(',')!=-1&& button.Text==",")
            {

            }
            else
            {
            textBox1.Text += button.Text;
            }
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            double answer=0;
            switch (act)
            {
                case ('+'):
                    answer = Convert.ToDouble(_tmp) + Convert.ToDouble(textBox1.Text);
                    break;
                case ('-'):
                    answer = Convert.ToDouble(_tmp) - Convert.ToDouble(textBox1.Text);
                    break;
                case ('*'):
                    answer = Convert.ToDouble(_tmp) * Convert.ToDouble(textBox1.Text);
                    break;
                case ('/'):
                    answer = Convert.ToDouble(_tmp) / Convert.ToDouble(textBox1.Text);
                    break;
                
            }
            textBox1.Text = Convert.ToString(answer);
        }

        private void buttonsubtraction_Click(object sender, EventArgs e)
        {
            act = '-';
            _tmp = textBox1.Text;
            textBox1.Text = "0";
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            act = '*';
            _tmp = textBox1.Text;
            textBox1.Text = "0";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            act = '/';
            _tmp = textBox1.Text;
            textBox1.Text = "0";
        }
        private void buttonSolve_Click(object sender, EventArgs e)
        {
            act = '+';
            _tmp = textBox1.Text;
            textBox1.Text = "0";
        }
    }
}
