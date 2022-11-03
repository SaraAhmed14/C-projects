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

namespace RESTAURANT_PROJECT
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Restauranty;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("select * from emp where username='" + usernameTxt.Text + "'and password='" + passTxt.Text + "'", con); 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                main_screen f = new main_screen();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("enter the right data");
            }
            con.Close();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void passTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
