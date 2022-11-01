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
    public partial class meny : Form
    {
        public meny()
        {
            InitializeComponent();
        }

        private void klik1_Click(object sender, EventArgs e)
        {
            Primer frm = new Primer();
            frm.Show();
            this.Hide();
        }

        private void Zadanie1_Click(object sender, EventArgs e)
        {
            Zadanie1 frm = new Zadanie1();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zadanie2 frm = new Zadanie2();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zadanie3 frm = new Zadanie3();
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zadanie4 frm = new Zadanie4();
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Zadanie5 frm = new Zadanie5();
            frm.Show();
            this.Hide();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void lab2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Zd1 frm = new Zd1();
            frm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Zd2 frm = new Zd2();
            frm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Zd3 frm = new Zd3();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Zd4 frm = new Zd4();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Zd5 frm = new Zd5();
            frm.Show();
            this.Hide();
        }

        private void meny_Load(object sender, EventArgs e)
        {

        }


        private void klik3_Click(object sender, EventArgs e)
        {
            Zad1 frm = new Zad1();
            frm.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Zad2 frm = new Zad2();
            frm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Zad3 frm = new Zad3();
            frm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Zad4 frm = new Zad4();
            frm.Show();
            this.Hide();
        }

        private void klik5_Click(object sender, EventArgs e)
        {
            Zad5 frm = new Zad5();
            frm.Show();
            this.Hide();
        }

        private void lab51_Click_1(object sender, EventArgs e)
        {
            lab51 frm = new lab51();
            frm.Show();
            this.Hide();
        }

        private void Lab52_Click_1(object sender, EventArgs e)
        {
             Lab52 frm = new Lab52();
             frm.Show();
             this.Hide();
        }

        private void Lab53_Click(object sender, EventArgs e)
        {
            Lab53 frm = new Lab53();
            frm.Show();
            this.Hide();
        }

        private void Lab54_Click_1(object sender, EventArgs e)
        {
            Lab54 frm = new Lab54();
            frm.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Lab55 frm = new Lab55();
            frm.Show();
            this.Hide();
        }
    }
}