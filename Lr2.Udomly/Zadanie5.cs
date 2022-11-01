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
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
        {
            InitializeComponent();
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

            double a = Math.Log(Math.Pow(y, -(Math.Sqrt(Math.Abs(x)))));
            double b = (x - y / 2);
            double c = Math.Pow(Math.Sin(Math.Atan(z)), 2);
            double d = a * b + c;

            textBox4.Text += Environment.NewLine + "Результат" + d.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
