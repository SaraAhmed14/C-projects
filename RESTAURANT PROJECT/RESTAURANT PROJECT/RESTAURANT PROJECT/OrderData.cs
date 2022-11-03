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
    public partial class OrderData : Form
    {
        public OrderData()
        {
            InitializeComponent();
        }

        private void the_orderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'restaurantyDataSet9.the_order' table. You can move, or remove it, as needed.
            this.the_orderTableAdapter.Fill(this.restaurantyDataSet9.the_order);
            // TODO: This line of code loads data into the 'restaurantyDataSet7.the_order' table. You can move, or remove it, as needed.
            this.the_orderTableAdapter1.Fill(this.restaurantyDataSet7.the_order);
            // TODO: This line of code loads data into the 'restaurantyDataSet.the_order' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'restaurantyDataSet8.the_order' table. You can move, or remove it, as needed.


        }

        private void the_orderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void the_orderDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void the_orderDataGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void the_orderDataGridView_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
