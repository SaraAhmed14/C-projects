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
    public partial class another_cs : Form
    {

        public static string city;
        public static string name;


        public another_cs()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void another_cs_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem == "Bani Sweif")
            {
                textBox1.Text = "Beni Suef - Safia Zaghloul St. - Railway Station";
                city = textBox1.Text;
            }
            else if (listBox2.SelectedItem == "Ismailia")
            {
                textBox1.Text = "Ismailia - El Horreya St. - Orabi Square";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Alexandria")
            {
                textBox1.Text = "Alexandria - Mahmoud Salama St. - Misr Station";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "The new Valley")
            {
                textBox1.Text = "New Valley - behind Hibs Cinema - next to Al Kharga Post Office";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Qena")
            {
                textBox1.Text = "Qena - Safina St., off Fawy St";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Tor Sinai")
            {
                textBox1.Text = "Tor Sinai - interest complex building";
                city = textBox1.Text;

            }

            else if (listBox2.SelectedItem == "Aswan")
            {
                textBox1.Text = "Aswan - Nile Corniche St. (Old Posta)";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Asyut")
            {
               textBox1.Text = "Assiut - in front of Badr Hotel";
                city = textBox1.Text;


            }
            else if (listBox2.SelectedItem == "Mansoura")
            {
               textBox1.Text = "El Galaa St., next to Matrouh Police Station";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "EL Sharqia")
            {
                textBox1.Text = "EL Sharqia - next to Zagazig Fire Station - in front of El Sawares Bridge";
                city = textBox1.Text;

            }

            else if (listBox2.SelectedItem == "Shbeen El Koom")
            {
                textBox1.Text = "Shebin El-Kom - Nasr St., off Talaat Harb St., on the eastern mainland Next to the bus";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Port Said")
            {
                textBox1.Text = "Port Said - Al-Amin and Al-Ansar St.";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Sohag")
            {
                textBox1.Text = "Sohag - Nile Corniche St.";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Suez")
            {
                textBox1.Text = "Suez - Al - Sabah City, Building 5, next to the Mosque of Sayyidna Hamza";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Hurghada")
            {
                textBox1.Text = "Hurghada - El Hegaz St., behind the second section, Hurghada - Hafar Al-Batin";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Minya")
            {
                textBox1.Text = "Minya - Saad Zaghloul St. - Railway Station Building";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Qalyubia")
            {
                textBox1.Text = "Qalyubia - Benha Post Traffic Center Station";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "North Sinai")
            {
                textBox1.Text = "North Sinai - Abu Bakr Al Siddiq Street - Beside Post Office 10 Arish";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Damietta")
            {
                textBox1.Text = "Damietta - El Tahrir St., in front of the old central building";
                city = textBox1.Text;

            }

            else if (listBox2.SelectedItem == " Damanhur")
            {
                textBox1.Text = "Damanhour - Al Mahatta Square";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Marsa Matrouh")
            {
                textBox1.Text = "Marsa Matrouh - Al-Galaa St., next to Matrouh Police Station";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Tanta")
            {
                textBox1.Text = "Tanta - the Directorate St., next to the railway - in front of the institute Religious";
                city = textBox1.Text;

            }
            else if (listBox2.SelectedItem == "Fayoum")
            {
                textBox1.Text = "Fayoum - Manshiet Wasfi";
                city = textBox1.Text;

            }

            else if (listBox2.SelectedItem == "Kafr El Sheikh")
            {
                textBox1.Text = "Kafr El Sheikh - El Nabawy El Mohandes St. - Beside El Khayyat Mosque";
                city = textBox1.Text;

            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || listBox2.SelectedItem == null)
            {
                MessageBox.Show("Enter all data");
            }
            else
            {
                name = textBox2.Text;
                this.Hide();
                DATA s = new DATA();
                s.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lost_Items L = new Lost_Items();
            L.Show();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
    }
}
