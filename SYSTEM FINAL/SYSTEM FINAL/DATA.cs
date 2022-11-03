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
    public partial class DATA : Form
    {
        public DATA()
        {
            InitializeComponent();
            textBox1.Text = another_cs.name;
            textBox5.Text = another_cs.city;
            textBox6.Text = Lost_Items.cash.ToString();
            textBox4.Text = "XXXXXX";
            textBox3.Text = Lost_Items.lost;
            textBox2.Text = Lost_Items.city;
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            another_cs s = new another_cs();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
