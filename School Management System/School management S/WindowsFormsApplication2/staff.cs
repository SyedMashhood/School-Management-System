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
    public partial class staff : Form
    {
        mycon con = new mycon();
        public staff()
        {
            InitializeComponent();
        }

        private void staff_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            string[] ms = {"single","married",};
            this.comboBox7.Items.AddRange(ms);
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                con.sqlConnection1.Open();
                SqlCommand cmd = new SqlCommand("insert into staf(REFNUMBER,NAME,FNAME,CNUMBER,DOARRIVAL,MARSTATUS,ADRESS) VALUES(@REFNUMBER,@NAME,@FNAME,@CNUMBER,@DOARRIVAL,@MARSTATUS,@ADRESS)", con.sqlConnection1);
                cmd.Parameters.AddWithValue("@REFNUMBER", textBox14.Text);
                cmd.Parameters.AddWithValue("@NAME", textBox13.Text);
                cmd.Parameters.AddWithValue("@FNAME", textBox12.Text);
                cmd.Parameters.AddWithValue("@CNUMBER", textBox16.Text);
                cmd.Parameters.AddWithValue("@DOARRIVAL", SqlDbType.Date).Value = dateTimePicker2.Value.Date;
                cmd.Parameters.AddWithValue("@MARSTATUS", comboBox7.Text);
                cmd.Parameters.AddWithValue("@ADRESS", textBox7.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has been inserted");
                con.sqlConnection1.Close();
            }
            catch (Exception ae)
            {
                MessageBox.Show("Error! " + ae, "Error! ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.sqlConnection1.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand("select * from STAF", con.sqlConnection1);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            this.dataGridView1.DataSource = dt;
        }
    }
}
