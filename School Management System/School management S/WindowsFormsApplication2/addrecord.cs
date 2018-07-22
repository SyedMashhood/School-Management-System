using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class addrecord : Form
    {
        public addrecord()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            staff st = new staff();
            st.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            tstaff ts = new tstaff();
            ts.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            stdrecord st = new stdrecord();
            st.Show();
        }

        private void addrecord_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            nontstaf ns = new nontstaf();
            ns.Show();
        }
    }
}
