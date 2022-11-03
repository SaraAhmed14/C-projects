using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SYSTEM_FINAL
{
    public partial class Lost_Items : Form
    {
        ArrayList ar = new ArrayList();
        public static String cash;
        public static String lost;
        public static String city;
        public Lost_Items()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
              
           
                ar.Add(10);
                lost += checkBox1.Text+" , ";
            }

            if (checkBox2.Checked == true)
            {
              
                ar.Add(5);
                lost += checkBox2.Text + " , ";

            }

            if (checkBox3.Checked == true)
            {
              
                ar.Add(5);
                lost += checkBox3.Text + " , ";

            }

            if (checkBox4.Checked == true)
            {
               
                ar.Add(10);
                lost += checkBox4.Text + " , ";

            }

            if (checkBox5.Checked == true)
            {
               
                ar.Add(10);
                lost += checkBox5.Text + " , ";

            }

            if (checkBox6.Checked == true)
            {
                ar.Add(10);
                lost += checkBox6.Text + " , ";

            }

            if (checkBox7.Checked == true)
            {
                
                ar.Add(10);
                lost += checkBox7.Text + " , ";


            }
            int totprice = 0;
            foreach (int a in ar)
            {
                totprice += a;
            }
            textBox2.Text = totprice.ToString()+" L.E";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
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
            if (listBox2.SelectedItem == null)
            {
                MessageBox.Show("blease choose the place");
            }
            else
            {
                this.Hide();
                another_cs s = new another_cs();
                s.Show();
                cash = textBox2.Text;
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox2.SelectedItem == "Bani Sweif")
            {
                
                city = "Bani Sweif";
            }
            else if (listBox2.SelectedItem == "Ismailia")
            {
                city = "Ismailia";


            }
            else if (listBox2.SelectedItem == "Alexandria")
            {
                city = "Alexandria";

            }
            else if (listBox2.SelectedItem == "The new Valley")
            {
                city = "The new Valley";

            }
            else if (listBox2.SelectedItem == "Qena")
            {
                city= "Qena";

            }
            else if (listBox2.SelectedItem == "Tor Sinai")
            {
                city = "Tor Sinai";

            }

            else if (listBox2.SelectedItem == "Aswan")
            {
                city = "Aswan";

            }
            else if (listBox2.SelectedItem == "Asyut")
            {
                city = "Asyut";


            }
            else if (listBox2.SelectedItem == "Mansoura")
            {
                city = "Mansoura";

            }
            else if (listBox2.SelectedItem == "EL Sharqia")
            {
                city = "EL Sharqia";
            }

            else if (listBox2.SelectedItem == "Shbeen El Koom")
            {

                city = "Shbeen El Koom";
            }
            else if (listBox2.SelectedItem == "Port Said")
            {
                city = "Port Said";

            }
            else if (listBox2.SelectedItem == "Sohag")
            {
                city = "Sohag";


            }
            else if (listBox2.SelectedItem == "Suez")
            {
                city = "Suez";

            }
            else if (listBox2.SelectedItem == "Hurghada")
            {

                city = "Hurghada";
            }
            else if (listBox2.SelectedItem == "Minya")
            {

                city = "Minya";
            }
            else if (listBox2.SelectedItem == "Qalyubia")
            {
                city = "Qalyubia";

            }
            else if (listBox2.SelectedItem == "North Sinai")
            {
                city = "North Sinai";

            }
            else if (listBox2.SelectedItem == "Damietta")
            {

                city = "Damietta";
            }

            else if (listBox2.SelectedItem == " Damanhur")
            {

                city = " Damanhur";
            }
            else if (listBox2.SelectedItem == "Marsa Matrouh")
            {
                city = "Marsa Matrouh";

            }
            else if (listBox2.SelectedItem == "Tanta")
            {
                city = "Tanta";

            }
            else if (listBox2.SelectedItem == "Fayoum")
            {
                city = "Fayoum";

            }

            else if (listBox2.SelectedItem == "Kafr El Sheikh")
            {
                city = "Kafr El Sheikh";

            }
        }
    }
}
