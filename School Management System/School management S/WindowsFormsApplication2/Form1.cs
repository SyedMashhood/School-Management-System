﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label5.Text = "An effort By Hafiz Muhammad Mashhood";
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            addrecord ad = new addrecord();
            ad.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
