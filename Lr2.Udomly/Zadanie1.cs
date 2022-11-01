using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr2.Udomly
{
    public partial class Zadanie1 : Form
    {
        public Zadanie1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void klik1_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }

        private void klik2_Click(object sender, EventArgs e)
        {
            double x = double.Parse(text1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();

            double y = double.Parse(text2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();

            double z = double.Parse(text3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = 2 * Math.Cos(x - Math.PI / 6);
            double b = 0.5 + Math.Pow(Math.Sin(y), 2);
            double c = 1 + Math.Pow(z, 2) / (3 - Math. Pow(z, 2) / 5);
            double t = a / b * c;


            textBox4.Text += Environment.NewLine + "Результат" + t.ToString();

        }

        private void Zadanie1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void text3_TextChanged(object sender, EventArgs e)
        {

        }

        private void text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
