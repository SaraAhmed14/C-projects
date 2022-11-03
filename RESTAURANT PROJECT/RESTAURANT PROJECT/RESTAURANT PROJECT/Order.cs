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
using System.Collections;
namespace RESTAURANT_PROJECT
{
    public partial class Order : Form
    {

        ArrayList ar = new ArrayList();
        public Order()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Restauranty;Integrated Security=True");

        private void addbtn_Click(object sender, EventArgs e)
        {



            SqlCommand CMD;
            con.Open();
            SqlDataReader r;


            if (one.Checked == true)
            {

                CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + one.Text, con);
                r = CMD.ExecuteReader();
                if (r.Read())
                {
                    itemTxt.Text = r[0].ToString();
                }
            }



            

            con.Close();
        }

        private void addbtn_Click_1(object sender, EventArgs e)
        {

            if (itemTxt.Text == "" || priceTxt.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("check if you enter all data");
            }
            else
            {
                int totalprice = (int.Parse(textBox2.Text) * int.Parse(priceTxt.Text));
                ar.Add(totalprice);
                textBox1.Text += textBox2.Text + " ";
                textBox1.Text += itemTxt.Text + " ";
                textBox1.Text += totalprice + "L.E" + Environment.NewLine;
                SqlCommand v = new SqlCommand("insert into the_order(quantity,price,D_ate) values(@q,@p,@D)", con);
                v.Parameters.AddWithValue("@q", int.Parse(textBox2.Text));
                v.Parameters.AddWithValue("@p", totalprice);
                v.Parameters.AddWithValue("@d", DateTime.Now);
                con.Open();
                int rowf = v.ExecuteNonQuery();
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand CMD;

                SqlDataReader r;
                int count = 0;

                if (one.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName ,price from Menu where itemsName='" + one.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();


                        count++;
                    }
                    con.Close();
                }
                else if (two.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + two.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (three.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + three.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();
                }

                else if (four.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + four.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (five.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + five.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();
                }
                else if (six.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + six.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (seven.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + seven.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (eight.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + eight.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (nine.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + nine.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (ten.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + ten.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (eleven.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + eleven.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (twelve.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + twelve.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
                else if (thirteen.Checked == true)
                {

                    CMD = new SqlCommand("select itemsName , price from Menu where itemsName='" + thirteen.Text + "'", con);
                    con.Open();
                    r = CMD.ExecuteReader();
                    if (r.Read())
                    {
                        itemTxt.Text = r[0].ToString();
                        priceTxt.Text = r[1].ToString();

                        count++;
                    }
                    con.Close();

                }
            }






            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }

            

         

        }

        private void priceTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderData od = new OrderData();
            od.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            priceTxt.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            int totprice = 0;
            foreach (int a in ar)
            {
                totprice += a;
            }
            textBox3.Text = totprice.ToString();
        }

        private void clearbtn_Click_1(object sender, EventArgs e)
        {
            itemTxt.Clear();
            priceTxt.Clear();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_screen m = new main_screen();
            m.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderData s = new OrderData();
            s.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_screen s = new main_screen();
            s.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void itemTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

