using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = double.Parse(textBox1.Text);

            double b = (a * 9 / 5) + 32;

            MessageBox.Show("Resultado: " + b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);

            double b = (a - 32) * 5 / 9;

            MessageBox.Show("Resultado: " + b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = a + 273.15;

            MessageBox.Show("Resultado: " + b);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = (a - 32) * 5 / 9 + 273.15;

            MessageBox.Show("Resultado: " + b);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = a - 273.15;

            MessageBox.Show("Resultado: " + b);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = (a - 273.15) * 9 / 5 + 32;

            MessageBox.Show("Resultado: " + b);
        }
    }
}
