namespace TourTest.Forms.Main
{
    partial class ZakazForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpPointDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickUpCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.User,
            this.dateOrderDataGridViewTextBoxColumn,
            this.tourIdDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn,
            this.pickUpPointDataGridViewTextBoxColumn,
            this.pickUpCodeDataGridViewTextBoxColumn,
            this.tourDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(843, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(TourTest.Models.Order);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0-10%",
            "11-14%",
            "15%"});
            this.comboBox1.Location = new System.Drawing.Point(149, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Фильтрация по скидке";
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "IdOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "IdOrder";
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // User
            // 
            this.User.HeaderText = "Пользователь";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            // 
            // dateOrderDataGridViewTextBoxColumn
            // 
            this.dateOrderDataGridViewTextBoxColumn.DataPropertyName = "DateOrder";
            this.dateOrderDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateOrderDataGridViewTextBoxColumn.Name = "dateOrderDataGridViewTextBoxColumn";
            this.dateOrderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tourIdDataGridViewTextBoxColumn
            // 
            this.tourIdDataGridViewTextBoxColumn.DataPropertyName = "TourId";
            this.tourIdDataGridViewTextBoxColumn.HeaderText = "Код тура";
            this.tourIdDataGridViewTextBoxColumn.Name = "tourIdDataGridViewTextBoxColumn";
            this.tourIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "Скидка";
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pickUpPointDataGridViewTextBoxColumn
            // 
            this.pickUpPointDataGridViewTextBoxColumn.DataPropertyName = "PickUpPoint";
            this.pickUpPointDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.pickUpPointDataGridViewTextBoxColumn.Name = "pickUpPointDataGridViewTextBoxColumn";
            this.pickUpPointDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pickUpCodeDataGridViewTextBoxColumn
            // 
            this.pickUpCodeDataGridViewTextBoxColumn.DataPropertyName = "PickUpCode";
            this.pickUpCodeDataGridViewTextBoxColumn.HeaderText = "Код заказа";
            this.pickUpCodeDataGridViewTextBoxColumn.Name = "pickUpCodeDataGridViewTextBoxColumn";
            this.pickUpCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tourDataGridViewTextBoxColumn
            // 
            this.tourDataGridViewTextBoxColumn.DataPropertyName = "Tour";
            this.tourDataGridViewTextBoxColumn.HeaderText = "Tour";
            this.tourDataGridViewTextBoxColumn.Name = "tourDataGridViewTextBoxColumn";
            this.tourDataGridViewTextBoxColumn.ReadOnly = true;
            this.tourDataGridViewTextBoxColumn.Visible = false;
            // 
            // ZakazForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ZakazForm";
            this.Text = "ZakazForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource orderBindingSource;
        private ComboBox comboBox1;
        private Label label1;
        private DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn User;
        private DataGridViewTextBoxColumn dateOrderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tourIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pickUpPointDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pickUpCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tourDataGridViewTextBoxColumn;
    }
}