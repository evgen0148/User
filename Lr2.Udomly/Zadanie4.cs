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
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
        {
            InitializeComponent();
        }

        private void zd1_Click(object sender, EventArgs e)
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

            double a = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2 * Math.Pow(Math.Sin(y), 2));
            double b = 1 + z + (Math.Pow(z, 2) / 2) + (Math.Pow(z, 3) / 3) + (Math.Pow(z, 4) / 4);
            double w = a * b;

            textBox4.Text += Environment.NewLine + "Результат" + w.ToString();
        }
    }
}
