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

namespace WindowsFormsApplication2
{
    public partial class stdrecord : Form
    {
        mycon con = new mycon();
        public stdrecord()
        {
            InitializeComponent();
        }

        private void stdrecord_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; 
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("insert into STUDENT(GRNUMBER,NAME,FNAME,CNUMBER,DOB,DOADMISSION,PCLASS,ADDRESS,COADMISSION,LSATTEND) VALUES(@GRNUMBER,@NAME,@FNAME,@CNUMBER,@DOB,@DOADMISSION,@PCLASS,@ADDRESS,@COADMISSION,@LSATTEND)", con.sqlConnection1);
                cmd.Parameters.AddWithValue("@GRNUMBER", textBox14.Text);
                cmd.Parameters.AddWithValue("@NAME", textBox13.Text);
                cmd.Parameters.AddWithValue("@FNAME", textBox12.Text);
                cmd.Parameters.AddWithValue("@CNUMBER", textBox16.Text);
                cmd.Parameters.AddWithValue("@DOB", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.AddWithValue("@PCLASS", comboBox5.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", textBox7.Text);
                cmd.Parameters.AddWithValue("@DOADMISSION", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                cmd.Parameters.AddWithValue("@COADMISSION", comboBox1.Text);
                cmd.Parameters.AddWithValue("@LSATTEND", textBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admission submited!!!!*");
                con.sqlConnection1.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error! " + ae, "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.sqlConnection1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            con.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from STUDENT", con.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
