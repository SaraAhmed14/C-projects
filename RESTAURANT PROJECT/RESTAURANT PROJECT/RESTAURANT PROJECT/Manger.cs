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
    public partial class Manger : Form
    {
        public Manger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("please enter all data");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Restauranty;Integrated Security=True");


                SqlCommand cmd = new SqlCommand("select * from manager where mng_m='" + textBox1.Text + "'and pass_m='" + textBox2.Text + "'", con); //بحط فيه ال insert ,update , delete
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Form2 f = new Form2();
                    f.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("enter the right data");
                }
                con.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_screen m = new main_screen();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
