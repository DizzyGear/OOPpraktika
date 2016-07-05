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

        private void button_Click(object sender, EventArgs e)
        {
            double firstValue = Convert.ToDouble(textBox1.Text);
            double secondValue = Convert.ToDouble(textBox2.Text);
            double result;
            switch (((Button) sender).Name)
            {
                case "button1":
                    result = firstValue + secondValue;
                    break;
                case "button2":
                    result = firstValue - secondValue;
                    break;
                case "button3":
                    result = firstValue * secondValue;
                    break;
                case "button4":
                    result = firstValue / secondValue;
                    break;
                default:
		            throw new Exception( "Неизвестная операция" );
            }

            textBox3.Text = result.ToString();

        }
    }
}
