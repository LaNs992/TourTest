namespace TourTest.Forms.Main.HelperForm
{
    partial class OrderViewer
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Countrylbl = new System.Windows.Forms.Label();
            this.Pricelbl = new System.Windows.Forms.Label();
            this.countlbl = new System.Windows.Forms.Label();
            this.Actuallbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TourTest.Properties.Resources.picture;
            this.pictureBox1.Location = new System.Drawing.Point(20, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(237, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(337, 64);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(366, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // Countrylbl
            // 
            this.Countrylbl.AutoSize = true;
            this.Countrylbl.Location = new System.Drawing.Point(697, 94);
            this.Countrylbl.Name = "Countrylbl";
            this.Countrylbl.Size = new System.Drawing.Size(46, 15);
            this.Countrylbl.TabIndex = 4;
            this.Countrylbl.Text = "Страна";
            // 
            // Pricelbl
            // 
            this.Pricelbl.AutoSize = true;
            this.Pricelbl.Location = new System.Drawing.Point(697, 169);
            this.Pricelbl.Name = "Pricelbl";
            this.Pricelbl.Size = new System.Drawing.Size(46, 15);
            this.Pricelbl.TabIndex = 5;
            this.Pricelbl.Text = "Страна";
            // 
            // countlbl
            // 
            this.countlbl.AutoSize = true;
            this.countlbl.Location = new System.Drawing.Point(697, 134);
            this.countlbl.Name = "countlbl";
            this.countlbl.Size = new System.Drawing.Size(46, 15);
            this.countlbl.TabIndex = 6;
            this.countlbl.Text = "Страна";
            // 
            // Actuallbl
            // 
            this.Actuallbl.AutoSize = true;
            this.Actuallbl.Location = new System.Drawing.Point(697, 46);
            this.Actuallbl.Name = "Actuallbl";
            this.Actuallbl.Size = new System.Drawing.Size(46, 15);
            this.Actuallbl.TabIndex = 7;
            this.Actuallbl.Text = "Страна";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(811, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(81, 23);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // OrderViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Actuallbl);
            this.Controls.Add(this.countlbl);
            this.Controls.Add(this.Pricelbl);
            this.Controls.Add(this.Countrylbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderViewer";
            this.Size = new System.Drawing.Size(916, 215);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label Countrylbl;
        private Label Pricelbl;
        private Label countlbl;
        private Label Actuallbl;
        private NumericUpDown numericUpDown1;
    }
}
