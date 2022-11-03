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
    public partial class Branch : Form
    {
        public Branch()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (idTxt.Text == "" || addrTxt.Text == "" || numTxt.Text == "")
            {
                MessageBox.Show("please enter all data");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Restauranty;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("insert into branch values(@branch_id,@phone,@address)", con);
                    cmd.Parameters.AddWithValue("@branch_id", idTxt.Text);
                    cmd.Parameters.AddWithValue("@phone", numTxt.Text);
                    cmd.Parameters.AddWithValue("@address", addrTxt.Text);
                    con.Open();
                    int rowf = cmd.ExecuteNonQuery();
                    if (rowf > 0)
                    {
                        MessageBox.Show("added succefully");
                    }
                    else
                    {
                        MessageBox.Show("not added");
                    }
                    con.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            main_screen m = new main_screen();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_screen m = new main_screen();
            m.Show();
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
