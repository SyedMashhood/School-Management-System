using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class tstaff : Form
    {
        mycon con = new mycon();
        public tstaff()
        {
            InitializeComponent();
        }

        private void tstaff_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string[] des = {"inter","graduate","master"};
            this.comboBox2.Items.AddRange(des);
            string[] ms = { "single", "Married",};
            this.comboBox7.Items.AddRange(ms);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.oleDbConnection1.Open();
                OleDbCommand cmd = new OleDbCommand("insert into tstaf ( ID, tname, fname, cno, doar, mstat ,address, qua , des) values (@ID, @tname, @fname, @cno, @doar, @mstat, @qua, @des,@address)", con.oleDbConnection1);
                cmd.Parameters.AddWithValue("@ID", textBox14.Text);
                cmd.Parameters.AddWithValue("@tname", textBox13.Text);
                cmd.Parameters.AddWithValue("@fname", textBox12.Text);
                cmd.Parameters.AddWithValue("@cno", textBox16.Text);
                cmd.Parameters.AddWithValue("@address", textBox7.Text);
                cmd.Parameters.AddWithValue("@doar", dateTimePicker2.Text);
                cmd.Parameters.AddWithValue("@mstat", comboBox7.Text);
                cmd.Parameters.AddWithValue("@qua", comboBox2.Text);
                cmd.Parameters.AddWithValue("@des", comboBox3.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been inserted");
                con.oleDbConnection1.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error! " + ae, "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.oleDbConnection1.Close();
        }
    }
}
