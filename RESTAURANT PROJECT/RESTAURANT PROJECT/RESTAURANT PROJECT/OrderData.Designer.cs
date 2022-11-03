namespace RESTAURANT_PROJECT
{
    partial class OrderData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderData));
            this.the_orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.the_orderBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.the_orderBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.the_orderBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantyDataSet7 = new RESTAURANT_PROJECT.RestaurantyDataSet7();
            this.the_orderBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.the_orderTableAdapter1 = new RESTAURANT_PROJECT.RestaurantyDataSet7TableAdapters.the_orderTableAdapter();
            this.tableAdapterManager1 = new RESTAURANT_PROJECT.RestaurantyDataSet7TableAdapters.TableAdapterManager();
            this.restaurantyDataSet9 = new RESTAURANT_PROJECT.RestaurantyDataSet9();
            this.the_orderBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.the_orderTableAdapter = new RESTAURANT_PROJECT.RestaurantyDataSet9TableAdapters.the_orderTableAdapter();
            this.tableAdapterManager = new RESTAURANT_PROJECT.RestaurantyDataSet9TableAdapters.TableAdapterManager();
            this.the_orderDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantyDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantyDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // the_orderBindingSource1
            // 
            this.the_orderBindingSource1.DataMember = "the_order";
            // 
            // the_orderBindingSource2
            // 
            this.the_orderBindingSource2.DataMember = "the_order";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(620, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 38);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // the_orderBindingSource3
            // 
            this.the_orderBindingSource3.DataMember = "the_order";
            // 
            // restaurantyDataSet7
            // 
            this.restaurantyDataSet7.DataSetName = "RestaurantyDataSet7";
            this.restaurantyDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // the_orderBindingSource4
            // 
            this.the_orderBindingSource4.DataMember = "the_order";
            this.the_orderBindingSource4.DataSource = this.restaurantyDataSet7;
            // 
            // the_orderTableAdapter1
            // 
            this.the_orderTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.the_orderTableAdapter = this.the_orderTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = RESTAURANT_PROJECT.RestaurantyDataSet7TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // restaurantyDataSet9
            // 
            this.restaurantyDataSet9.DataSetName = "RestaurantyDataSet9";
            this.restaurantyDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // the_orderBindingSource5
            // 
            this.the_orderBindingSource5.DataMember = "the_order";
            this.the_orderBindingSource5.DataSource = this.restaurantyDataSet9;
            // 
            // the_orderTableAdapter
            // 
            this.the_orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.the_orderTableAdapter = this.the_orderTableAdapter;
            this.tableAdapterManager.UpdateOrder = RESTAURANT_PROJECT.RestaurantyDataSet9TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // the_orderDataGridView
            // 
            this.the_orderDataGridView.AutoGenerateColumns = false;
            this.the_orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.the_orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.the_orderDataGridView.DataSource = this.the_orderBindingSource5;
            this.the_orderDataGridView.Location = new System.Drawing.Point(12, 46);
            this.the_orderDataGridView.Name = "the_orderDataGridView";
            this.the_orderDataGridView.RowHeadersWidth = 62;
            this.the_orderDataGridView.RowTemplate.Height = 28;
            this.the_orderDataGridView.Size = new System.Drawing.Size(660, 487);
            this.the_orderDataGridView.TabIndex = 20;
            this.the_orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.the_orderDataGridView_CellContentClick_3);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "orderNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "orderNo";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "quantity";
            this.dataGridViewTextBoxColumn5.HeaderText = "quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn6.HeaderText = "price";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "D_ate";
            this.dataGridViewTextBoxColumn7.HeaderText = "D_ate";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // OrderData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(692, 553);
            this.Controls.Add(this.the_orderDataGridView);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderData";
            this.Text = "OrderData";
            this.Load += new System.EventHandler(this.OrderData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantyDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantyDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.the_orderDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       
        private System.Windows.Forms.BindingSource the_orderBindingSource;
       
        private System.Windows.Forms.BindingSource the_orderBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
 
        private System.Windows.Forms.BindingSource the_orderBindingSource2;
      
        private System.Windows.Forms.Button button3;
       
        private System.Windows.Forms.BindingSource the_orderBindingSource3;
      
        private RestaurantyDataSet7 restaurantyDataSet7;
        private System.Windows.Forms.BindingSource the_orderBindingSource4;
        private RestaurantyDataSet7TableAdapters.the_orderTableAdapter the_orderTableAdapter1;
        private RestaurantyDataSet7TableAdapters.TableAdapterManager tableAdapterManager1;
        private RestaurantyDataSet9 restaurantyDataSet9;
        private System.Windows.Forms.BindingSource the_orderBindingSource5;
        private RestaurantyDataSet9TableAdapters.the_orderTableAdapter the_orderTableAdapter;
        private RestaurantyDataSet9TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView the_orderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}