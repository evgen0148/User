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
    public partial class Zad2 : Form
    {
        public Zad2()
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
                double y = 1.2 * (Math.Pow((a - b), 3) * Math.Pow(Math.Pow(Math.E, x), 2)) + x;
                textBox4.Text += "x =" + Convert.ToString(x) + "; y =" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
