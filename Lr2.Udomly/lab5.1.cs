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
    public partial class lab51 : Form
    {
        public lab51()
        {
            InitializeComponent();
        }

        private void klik4_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }

        private void lab51_MouseClick(object sender, MouseEventArgs e)
        {
            Button b = new Button()
            {
                Location = e.Location,
            };
            this.Controls.Add(b);
            b.Text = e.Location.X + ";" + e.Location.Y;
        }
    }
}
