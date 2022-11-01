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
    public partial class Lab52 : Form
    {
        public Lab52()
        {
            InitializeComponent();
        }

        private void klik4_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }

        private void Lab52_MouseClick(object sender, MouseEventArgs e)
        {
            int p = this.Width;
            if (e.Location.X < (p / 2) && e.Location.X > 0)
            {
                Button b = new Button()
                {
                    Location = e.Location,
                };
                this.Controls.Add(b);
                b.Text = e.Location.X + ";" + e.Location.Y;
            }
            else
            {
                TextBox b = new TextBox()
                {
                    Location = e.Location,
                };
                this.Controls.Add(b);
                b.Text = e.Location.X + ";" + e.Location.Y;
            }
        } 

        private void Lab52_Load(object sender, EventArgs e)
        {

        }
    }
}
