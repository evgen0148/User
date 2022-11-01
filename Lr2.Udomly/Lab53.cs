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
    public partial class Lab53 : Form
    {
        public Lab53()
        {
            InitializeComponent();
        }

        private void klik4_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button()
            {
                Location = e.Location,
            };
            panel1.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;

        }

        private void Lab53_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox b = new TextBox()
            {
                Location = panel1.Location,
            };
            panel1.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
