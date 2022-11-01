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
    public partial class Zad4 : Form
    {
        public Zad4()
        {
            InitializeComponent();
        }

        private void klik4_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }

        private void klik3_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textx0.Text);
            double xk = Convert.ToDouble(textxk.Text);
            double dx = Convert.ToDouble(textdx.Text);
            double a = Convert.ToDouble(texta.Text);
            double b = Convert.ToDouble(textb.Text);

            textBox4.Text = "Результат" + Environment.NewLine;

            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                textBox4.Text += "x =" + Convert.ToString(x) + "; y =" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void texta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textdx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textxk_TextChanged(object sender, EventArgs e)
        {

        }

        private void textx0_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
