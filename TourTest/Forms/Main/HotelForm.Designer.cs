namespace TourTest.Forms.Main
{
    partial class HotelForm
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
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UserN = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.butAdd = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfStarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelImagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.countOfStarsDataGridViewTextBoxColumn,
            this.countryCodeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.countryCodeNavigationDataGridViewTextBoxColumn,
            this.hotelCommentsDataGridViewTextBoxColumn,
            this.hotelImagesDataGridViewTextBoxColumn,
            this.toursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hotelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(514, 338);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(TourTest.Models.Hotel);
            // 
            // UserN
            // 
            this.UserN.AutoSize = true;
            this.UserN.Location = new System.Drawing.Point(12, 9);
            this.UserN.Name = "UserN";
            this.UserN.Size = new System.Drawing.Size(84, 15);
            this.UserN.TabIndex = 4;
            this.UserN.Text = "Пользователь";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 427);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(523, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // butAdd
            // 
            this.butAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.butAdd.FlatAppearance.BorderSize = 0;
            this.butAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAdd.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butAdd.Location = new System.Drawing.Point(100, 23);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(135, 33);
            this.butAdd.TabIndex = 12;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = false;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butDel
            // 
            this.butDel.BackColor = System.Drawing.Color.RoyalBlue;
            this.butDel.FlatAppearance.BorderSize = 0;
            this.butDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butDel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butDel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butDel.Location = new System.Drawing.Point(382, 23);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(135, 33);
            this.butDel.TabIndex = 13;
            this.butDel.Text = "УДАЛИТЬ";
            this.butDel.UseVisualStyleBackColor = false;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // butEdit
            // 
            this.butEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.butEdit.FlatAppearance.BorderSize = 0;
            this.butEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butEdit.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butEdit.Location = new System.Drawing.Point(241, 23);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(135, 33);
            this.butEdit.TabIndex = 14;
            this.butEdit.Text = "ИЗМЕНИТЬ";
            this.butEdit.UseVisualStyleBackColor = false;
            this.butEdit.Click += new System.EventHandler(this.butEdit_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countOfStarsDataGridViewTextBoxColumn
            // 
            this.countOfStarsDataGridViewTextBoxColumn.DataPropertyName = "CountOfStars";
            this.countOfStarsDataGridViewTextBoxColumn.HeaderText = "Звезды";
            this.countOfStarsDataGridViewTextBoxColumn.Name = "countOfStarsDataGridViewTextBoxColumn";
            this.countOfStarsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = " Страна";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            this.countryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Visible = false;
            // 
            // countryCodeNavigationDataGridViewTextBoxColumn
            // 
            this.countryCodeNavigationDataGridViewTextBoxColumn.DataPropertyName = "CountryCodeNavigation";
            this.countryCodeNavigationDataGridViewTextBoxColumn.HeaderText = "CountryCodeNavigation";
            this.countryCodeNavigationDataGridViewTextBoxColumn.Name = "countryCodeNavigationDataGridViewTextBoxColumn";
            this.countryCodeNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            this.countryCodeNavigationDataGridViewTextBoxColumn.Visible = false;
            // 
            // hotelCommentsDataGridViewTextBoxColumn
            // 
            this.hotelCommentsDataGridViewTextBoxColumn.DataPropertyName = "HotelComments";
            this.hotelCommentsDataGridViewTextBoxColumn.HeaderText = "HotelComments";
            this.hotelCommentsDataGridViewTextBoxColumn.Name = "hotelCommentsDataGridViewTextBoxColumn";
            this.hotelCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelCommentsDataGridViewTextBoxColumn.Visible = false;
            // 
            // hotelImagesDataGridViewTextBoxColumn
            // 
            this.hotelImagesDataGridViewTextBoxColumn.DataPropertyName = "HotelImages";
            this.hotelImagesDataGridViewTextBoxColumn.HeaderText = "HotelImages";
            this.hotelImagesDataGridViewTextBoxColumn.Name = "hotelImagesDataGridViewTextBoxColumn";
            this.hotelImagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.hotelImagesDataGridViewTextBoxColumn.Visible = false;
            // 
            // toursDataGridViewTextBoxColumn
            // 
            this.toursDataGridViewTextBoxColumn.DataPropertyName = "Tours";
            this.toursDataGridViewTextBoxColumn.HeaderText = "Tours";
            this.toursDataGridViewTextBoxColumn.Name = "toursDataGridViewTextBoxColumn";
            this.toursDataGridViewTextBoxColumn.ReadOnly = true;
            this.toursDataGridViewTextBoxColumn.Visible = false;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 449);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.UserN);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HotelForm";
            this.Text = "Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label UserN;
        private StatusStrip statusStrip;
        private BindingSource hotelBindingSource;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Button butAdd;
        private Button butDel;
        private Button butEdit;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countOfStarsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotelCommentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotelImagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toursDataGridViewTextBoxColumn;
    }
}