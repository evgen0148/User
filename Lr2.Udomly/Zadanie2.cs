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
    public partial class Zadanie2: Form
    {
        private Label label3;
        private Label label2;
        private TextBox text1;
        private TextBox text2;
        private TextBox text3;
        private Label zd1;
        private Button klik1;
        private Button klik2;
        private Label label4;
        private TextBox textBox4;
        private Label label1;

        public Zadanie2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.zd1 = new System.Windows.Forms.Label();
            this.klik1 = new System.Windows.Forms.Button();
            this.klik2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите значение X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите значение Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(11, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите значение Z";
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(233, 44);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(191, 22);
            this.text1.TabIndex = 7;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(233, 75);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(191, 22);
            this.text2.TabIndex = 8;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(233, 108);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(191, 22);
            this.text3.TabIndex = 9;
            // 
            // zd1
            // 
            this.zd1.AutoSize = true;
            this.zd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zd1.Location = new System.Drawing.Point(274, 9);
            this.zd1.Name = "zd1";
            this.zd1.Size = new System.Drawing.Size(123, 20);
            this.zd1.TabIndex = 10;
            this.zd1.Text = "Задание №2";
            // 
            // klik1
            // 
            this.klik1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.klik1.Location = new System.Drawing.Point(602, 46);
            this.klik1.Name = "klik1";
            this.klik1.Size = new System.Drawing.Size(80, 36);
            this.klik1.TabIndex = 11;
            this.klik1.Text = "Назад";
            this.klik1.UseVisualStyleBackColor = true;
            this.klik1.Click += new System.EventHandler(this.klik1_Click);
            // 
            // klik2
            // 
            this.klik2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.klik2.Location = new System.Drawing.Point(591, 100);
            this.klik2.Name = "klik2";
            this.klik2.Size = new System.Drawing.Size(134, 36);
            this.klik2.TabIndex = 12;
            this.klik2.Text = "Выполнить";
            this.klik2.UseVisualStyleBackColor = true;
            this.klik2.Click += new System.EventHandler(this.klik2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Результат выполнения программы";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(15, 178);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(400, 200);
            this.textBox4.TabIndex = 14;
            // 
            // Zadanie2
            // 
            this.ClientSize = new System.Drawing.Size(763, 482);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.klik2);
            this.Controls.Add(this.klik1);
            this.Controls.Add(this.zd1);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Zadanie2";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

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

            double a = Math.Pow((8 + Math.Pow((Math.Abs(x-y)),2) +1), 1 / 3);
            double b = Math.Pow(x, 2) + Math.Pow(y, 2) + 2;
            double c = Math.Pow(Math.E, Math.Abs(x - y));
            double d = Math.Pow((Math.Pow(Math.Tan(z), 2) + 1), x);
            double u = a / b - c * d;

            textBox4.Text += Environment.NewLine + "Результат" + u.ToString();
        }
    }
}
