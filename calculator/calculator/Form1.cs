using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue =  Convert.ToDouble(textBox1.Text) ;
            double secondValue = Convert.ToDouble(textBox2.Text);
            double thirdValue = firstValue + secondValue;
            textBox3.Text = thirdValue.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double thirdValue = firstValue - secondValue;
            textBox3.Text = thirdValue.ToString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double thirdValue = firstValue * secondValue;
            textBox3.Text = thirdValue.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double thirdValue = firstValue / secondValue;
            textBox3.Text = thirdValue.ToString();
        }
    }
}
