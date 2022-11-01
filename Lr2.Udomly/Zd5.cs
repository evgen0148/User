﻿using System;
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
    public partial class Zd5 : Form
    {
        public Zd5()
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
            double x = Convert.ToDouble(text1X.Text);
            double y = Convert.ToDouble(text2Y.Text);
            double f = 0;

            textBox4.Text = "Результат" + Environment.NewLine;
            textBox4.Text += "x = " + text1X.Text + Environment.NewLine;
            textBox4.Text += "y = " + text2Y.Text + Environment.NewLine;

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

            double s = 0;
            if (y%2==1 && x > 0)
            {
                s = y*Math.Sign(f);
            }
            else if (y%2==0 && x < 0)
            {
                s = y/2*Math.Sign(Math.Abs(f));
            }
            else
            {
                s = Math.Sign(Math.Abs(y * f));
            }

            textBox4.Text += "Результат s =" + s.ToString() + Environment.NewLine;
        }
    }
}
