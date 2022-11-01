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
    public partial class Lab54 : Form
    {
        public Lab54()
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
            panel2.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox b = new TextBox()
            {
                Location = e.Location,
            };
            panel3.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;
        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            Label b = new Label()
            {
                Location = e.Location,
            };
            panel1.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
