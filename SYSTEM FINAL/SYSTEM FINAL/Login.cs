﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYSTEM_FINAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lost_Items L = new Lost_Items();
            L.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F = new Form1();
            F.Show();
                
             
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
