namespace TourTest.Forms.Main
{
    partial class TourViewer
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureTour = new System.Windows.Forms.PictureBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.Actual = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.CountTick = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureTour
            // 
            this.pictureTour.Image = global::TourTest.Properties.Resources.picture;
            this.pictureTour.Location = new System.Drawing.Point(44, 38);
            this.pictureTour.Name = "pictureTour";
            this.pictureTour.Size = new System.Drawing.Size(152, 135);
            this.pictureTour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTour.TabIndex = 4;
            this.pictureTour.TabStop = false;
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEdit.Location = new System.Drawing.Point(3, 256);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(118, 40);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "ИЗМЕНИТЬ";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click_1);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdd.Location = new System.Drawing.Point(132, 256);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(118, 40);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "ИЗОБРАЖЕНИЕ";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // Actual
            // 
            this.Actual.AutoSize = true;
            this.Actual.BackColor = System.Drawing.Color.Transparent;
            this.Actual.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Actual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Actual.Location = new System.Drawing.Point(16, 222);
            this.Actual.Name = "Actual";
            this.Actual.Size = new System.Drawing.Size(37, 19);
            this.Actual.TabIndex = 7;
            this.Actual.Text = "Login";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.BackColor = System.Drawing.Color.Transparent;
            this.NameLb.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLb.Location = new System.Drawing.Point(44, 7);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(37, 19);
            this.NameLb.TabIndex = 8;
            this.NameLb.Text = "Login";
            // 
            // CountTick
            // 
            this.CountTick.AutoSize = true;
            this.CountTick.BackColor = System.Drawing.Color.Transparent;
            this.CountTick.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountTick.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CountTick.Location = new System.Drawing.Point(159, 222);
            this.CountTick.Name = "CountTick";
            this.CountTick.Size = new System.Drawing.Size(37, 19);
            this.CountTick.TabIndex = 9;
            this.CountTick.Text = "Login";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.BackColor = System.Drawing.Color.Transparent;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Price.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Price.Location = new System.Drawing.Point(71, 185);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(53, 20);
            this.Price.TabIndex = 10;
            this.Price.Text = "Login";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image(*.jpg)|*.jpg";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(184, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem1.Text = "Добавить в корзину";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // TourViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.Price);
            this.Controls.Add(this.CountTick);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.Actual);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureTour);
            this.Name = "TourViewer";
            this.Size = new System.Drawing.Size(253, 315);
            this.Load += new System.EventHandler(this.TourView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureTour)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureTour;
        private Button buttonEdit;
        private Button buttonAdd;
        private Label Actual;
        private Label NameLb;
        private Label CountTick;
        private Label Price;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}
