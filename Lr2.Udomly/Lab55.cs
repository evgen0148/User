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
    public partial class Lab55 : Form
    {
        public Lab55()
        {
            InitializeComponent();
        }

        private void klik4_Click(object sender, EventArgs e)
        {
            meny frm = new meny();
            frm.Show();
            this.Hide();
        }

        private void Lab55_Load(object sender, EventArgs e)
        {

        }

        private void Lab55_MouseClick(object sender, MouseEventArgs e)
        {
            int x = 15;
            int y = 15;
            int r = 15;
            for (int i = 0; i < x*y; i++)
            {
                Button b = new Button();
                b.Location = new Point((i%x+1)*r,(i/y+1)*r);
                b.Size=new Size(15,15);
                this.Controls.Add(b);
            }
        }
    }
}
