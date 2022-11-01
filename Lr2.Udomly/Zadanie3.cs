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
    public partial class Zadanie3 : Form
    {
        public Zadanie3()
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

            double a = 1 + Math.Pow(Math.Sin(x + y),2);
            double b = Math.Abs(x-((2*y)/(1+Math.Pow(x,2)*Math.Pow(y,2))));
            double c = Math.Pow(x, Math.Abs(y));
            double d = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);
            double v = a / b * c + d;

            textBox4.Text += Environment.NewLine + "Результат" + v.ToString();
        }
    }
}
