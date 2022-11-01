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
    public partial class Zd2 : Form
    {
        public Zd2()
        {
            InitializeComponent();
        }

        private void klik2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(text1X.Text);
            double y = Convert.ToDouble(text2Y.Text);
            double f = 0;

            textBox4.Text = "Результат" + Environment.NewLine;
            textBox4.Text = "x = " + text1X.Text + Environment.NewLine;
            textBox4.Text = "y = " + text2Y.Text + Environment.NewLine;

            if (sinys.Checked)
            {
                f = Math.Sinh(x);
            }
            if (stepen.Checked)
            {
                f = Math.Pow(x, 2);
            }
            if (expanenta.Checked)
            {
                f = Math.Exp(x);
            }
            double a=0;
            if (x / y > 0 && y != 0)
            {
                a = Math.Log(f) + Math.Pow((Math.Pow(f,2)+y),3);
            }
            else if (x / y < 0 && y != 0)
            {
                a = Math.Log(Math.Abs(f/y)) + Math.Pow((f+y), 3);
            }
            else if (x == 0)
            {
                a = Math.Pow((Math.Pow(f, 2) + y), 3);
            }
            else if (y == 0)
            {
                a = 0;
            }

                textBox4.Text += "Результат a =" + a.ToString() + Environment.NewLine;
        }

        private void klik1_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }
    }
}
