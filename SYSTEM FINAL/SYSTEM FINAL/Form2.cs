using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            textBox2.Text = "******";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DATA D = new DATA();
            D.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you will recieving all items soon ");
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = (true);
            label4.Visible = (true);
            textBox3.Visible = (true);
            textBox4.Visible = (true);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you will recieving all items soon ");
        }
    }
}
