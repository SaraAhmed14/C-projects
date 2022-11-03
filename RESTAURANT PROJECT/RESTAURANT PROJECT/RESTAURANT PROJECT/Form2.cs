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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Restauranty;Integrated Security=True");



        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantyDataSet10.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter.Fill(this.restaurantyDataSet10.emp);
            // TODO: This line of code loads data into the 'restaurantyDataSet5.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter2.Fill(this.restaurantyDataSet5.emp);
            // TODO: This line of code loads data into the 'restaurantyDataSet4.emp' table. You can move, or remove it, as needed.
            this.empTableAdapter1.Fill(this.restaurantyDataSet4.emp);
            // TODO: This line of code loads data into the 'restaurantyDataSet3.branch' table. You can move, or remove it, as needed.
            this.branchTableAdapter.Fill(this.restaurantyDataSet3.branch);
            // TODO: This line of code loads data into the 'restaurantyDataSet.emp' table. You can move, or remove it, as needed.
            


        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == (null))
            {
                MessageBox.Show("please enter the employee id");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select name,username,password,ssn,address,telephone,position,gender,salary,branch_id from emp where id='" + comboBox1.Text + "'", con);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox11.Text = dr[0].ToString();
                    textBox9.Text = dr[1].ToString();
                    textBox10.Text = dr[2].ToString();
                    textBox5.Text = dr[3].ToString();
                    textBox4.Text = dr[4].ToString();
                    textBox6.Text = dr[5].ToString();
                    textBox8.Text = dr[6].ToString();
                    textBox2.Text = dr[7].ToString();
                    textBox3.Text = dr[8].ToString();
                    textBox7.Text = dr[9].ToString();


                }
                else
                {
                    MessageBox.Show("enter the right data");
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "select * from emp";
            SqlCommand cmd = new SqlCommand(query,con);
            
            SqlDataReader dr = cmd.ExecuteReader(); 
            if (dr.Read())
            {
                textBox1.Text= dr[0].ToString();
            }
            else
            {
                MessageBox.Show("mmmm");
            }
            con.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
       
        }

        private void subBtn_Click_2(object sender, EventArgs e)
        {
            if (idTxt.Text == "" || nameTxt.Text == "" || ssnTxt.Text == "" || passTxt.Text == "" || genderTxt.Text == "" || posTxt.Text == "" || phoneTxt.Text == "" || addrTxt.Text == "" || usernameTxt.Text == "" || comboBox2.SelectedItem == null || salaTxt.Text == "")

            {
                MessageBox.Show("enter all data");
            }
            else
            {

                SqlCommand cmd = new SqlCommand("insert into emp values(@id,@name,@username,@password,@ssn,@address,@telephone,@position,@gender,@salary,@branch_id)", con);
                cmd.Parameters.AddWithValue("@id", idTxt.Text);
                cmd.Parameters.AddWithValue("@name", nameTxt.Text);
                cmd.Parameters.AddWithValue("@username", usernameTxt.Text);
                cmd.Parameters.AddWithValue("@password", passTxt.Text);
                cmd.Parameters.AddWithValue("@ssn", ssnTxt.Text);
                cmd.Parameters.AddWithValue("@address", addrTxt.Text);
                cmd.Parameters.AddWithValue("@telephone", phoneTxt.Text);
                cmd.Parameters.AddWithValue("@position", posTxt.Text);
                cmd.Parameters.AddWithValue("@gender", genderTxt.Text);
                cmd.Parameters.AddWithValue("@salary", float.Parse(salaTxt.Text));
                if (branchCombobox.Text == "Helioples")
                {
                    cmd.Parameters.AddWithValue("@branch_id", 2);
                }
                else if (branchCombobox.Text == "Nasr City")
                {
                    cmd.Parameters.AddWithValue("@branch_id", 1);
                }
                else if (branchCombobox.Text == "New cairo")
                {
                    cmd.Parameters.AddWithValue("@branch_id", 3);
                }




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
            
        }

        private void deletebtn_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                MessageBox.Show("enter employee id");
            }
            else
            {
                con.Open();
                string query = "delete from emp where id='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                int rowf = cmd.ExecuteNonQuery();
                if (rowf > 0)
                {
                    MessageBox.Show("removed sucess");

                }
                else
                {
                    MessageBox.Show("");
                }
                con.Close();
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == null)
            {
                MessageBox.Show("please choose the employee id");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("select password,address,salary from emp where id='" + comboBox2.Text + "'", con);


                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                    textBox21.Text = dr[0].ToString();
                    textBox15.Text = dr[1].ToString();

                    textBox14.Text = dr[2].ToString();





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
            if (textBox13.Text == null || textBox16.Text == null || textBox17.Text == null)
            {
                MessageBox.Show("enter all data");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("update emp set password=@password,address=@address,salary=@salary where id=@id", con);
                cmd.Parameters.AddWithValue("@id", comboBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox17.Text);
                cmd.Parameters.AddWithValue("@address", textBox16.Text);
                cmd.Parameters.AddWithValue("@salary", float.Parse(textBox13.Text));
                con.Open();
                int rowf = cmd.ExecuteNonQuery();
                if (rowf > 0)
                {
                    MessageBox.Show("updated succefully");
                }
                else
                {
                    MessageBox.Show("not updated ");
                }
                con.Close();
            }
        }

        private void addpage_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_screen f = new main_screen();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void salaTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void salaTxt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter only nunmbers");

            }
            else
            {
                e.Handled = false;
            }
        }

        private void ssnTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("please enter only nunmbers");

            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
