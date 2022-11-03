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
    public partial class Form1 : Form
    {
        int  move ;
         int   movex ;
         int   movey ;
     


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADMIN A = new ADMIN();
            A.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration R = new Registration();
            R.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movex = e.X;
            movey = e.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (move==1)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Visible = (true); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox2.Visible = (true);
        }
    }
}
