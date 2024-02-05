namespace TourTest.Forms.Main
{
    partial class Hotel
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfStarsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryCodeNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelCommentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelImagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.butAdd = new System.Windows.Forms.Button();
            this.butEdit = new System.Windows.Forms.Button();
            this.butDel = new System.Windows.Forms.Button();
            this.UserN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
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
            this.dataGridView1.Size = new System.Drawing.Size(844, 338);
            this.dataGridView1.TabIndex = 0;
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
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countOfStarsDataGridViewTextBoxColumn
            // 
            this.countOfStarsDataGridViewTextBoxColumn.DataPropertyName = "CountOfStars";
            this.countOfStarsDataGridViewTextBoxColumn.HeaderText = "CountOfStars";
            this.countOfStarsDataGridViewTextBoxColumn.Name = "countOfStarsDataGridViewTextBoxColumn";
            this.countOfStarsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryCodeDataGridViewTextBoxColumn
            // 
            this.countryCodeDataGridViewTextBoxColumn.DataPropertyName = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.HeaderText = "CountryCode";
            this.countryCodeDataGridViewTextBoxColumn.Name = "countryCodeDataGridViewTextBoxColumn";
            this.countryCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryCodeNavigationDataGridViewTextBoxColumn
            // 
            this.countryCodeNavigationDataGridViewTextBoxColumn.DataPropertyName = "CountryCodeNavigation";
            this.countryCodeNavigationDataGridViewTextBoxColumn.HeaderText = "CountryCodeNavigation";
            this.countryCodeNavigationDataGridViewTextBoxColumn.Name = "countryCodeNavigationDataGridViewTextBoxColumn";
            this.countryCodeNavigationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelCommentsDataGridViewTextBoxColumn
            // 
            this.hotelCommentsDataGridViewTextBoxColumn.DataPropertyName = "HotelComments";
            this.hotelCommentsDataGridViewTextBoxColumn.HeaderText = "HotelComments";
            this.hotelCommentsDataGridViewTextBoxColumn.Name = "hotelCommentsDataGridViewTextBoxColumn";
            this.hotelCommentsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelImagesDataGridViewTextBoxColumn
            // 
            this.hotelImagesDataGridViewTextBoxColumn.DataPropertyName = "HotelImages";
            this.hotelImagesDataGridViewTextBoxColumn.HeaderText = "HotelImages";
            this.hotelImagesDataGridViewTextBoxColumn.Name = "hotelImagesDataGridViewTextBoxColumn";
            this.hotelImagesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toursDataGridViewTextBoxColumn
            // 
            this.toursDataGridViewTextBoxColumn.DataPropertyName = "Tours";
            this.toursDataGridViewTextBoxColumn.HeaderText = "Tours";
            this.toursDataGridViewTextBoxColumn.Name = "toursDataGridViewTextBoxColumn";
            this.toursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(TourTest.Models.Hotel);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(440, 27);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(116, 29);
            this.butAdd.TabIndex = 1;
            this.butAdd.Text = "Добавить";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butEdit
            // 
            this.butEdit.Location = new System.Drawing.Point(577, 27);
            this.butEdit.Name = "butEdit";
            this.butEdit.Size = new System.Drawing.Size(116, 29);
            this.butEdit.TabIndex = 2;
            this.butEdit.Text = "Изменить";
            this.butEdit.UseVisualStyleBackColor = true;
            // 
            // butDel
            // 
            this.butDel.Location = new System.Drawing.Point(721, 27);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(116, 29);
            this.butDel.TabIndex = 3;
            this.butDel.Text = "Удалить";
            this.butDel.UseVisualStyleBackColor = true;
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
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 449);
            this.Controls.Add(this.UserN);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.butEdit);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Hotel";
            this.Text = "Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countOfStarsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryCodeNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotelCommentsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotelImagesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toursDataGridViewTextBoxColumn;
        private BindingSource hotelBindingSource;
        private Button butAdd;
        private Button butEdit;
        private Button butDel;
        private Label UserN;
    }
}