using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class nontstaf : Form
    {
        mycon con = new mycon();
        public nontstaf()
        {
            InitializeComponent();
        }
        private void nontstaf_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from NTSTAF", con.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dataGridView1.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("insert into ntstaf (GRNO, NAME, FNAME, CNO, ADRESS) values (@GRNO, @NAME, @FNAME, @CNO, @ADRESS)", con.sqlConnection1);
                cmd.Parameters.AddWithValue("@GRNO", textBox14.Text);
                cmd.Parameters.AddWithValue("@NAME", textBox13.Text);
                cmd.Parameters.AddWithValue("@FNAME", textBox12.Text);
                cmd.Parameters.AddWithValue("@CNO", textBox16.Text);
                cmd.Parameters.AddWithValue("@ADRESS", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been inserted");
                con.sqlConnection1.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error! " + ae , "Error! ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            con.sqlConnection1.Close();
        }
    }
}
