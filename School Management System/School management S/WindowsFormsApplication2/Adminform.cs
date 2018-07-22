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
    public partial class Adminform : Form
    {
        public Adminform()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Adminform_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                Form1 f1 = new Form1();
                f1.Show();

            }
            else
            {
                MessageBox.Show("username or Password incorrect \n please try again");
                this.textBox1.BackColor = Color.Red;
                this.textBox2.BackColor = Color.Red;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
            }
        }
    }
}
