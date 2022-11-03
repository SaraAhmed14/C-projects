using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTAURANT_PROJECT
{
    public partial class main_screen : Form
    {
        public main_screen()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Branch b = new Branch();
            b.Show();
            this.Hide();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.ShowDialog();
            this.Hide();
        }

        private void main_screen_Load(object sender, EventArgs e)
        {

        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
           
            this.Close();
            Manger f = new Manger();
            f.Show();
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Menu m1 = new Menu();
            m1.ShowDialog();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Customer c = new Customer();
            c.ShowDialog();
        }

       
    }
}
