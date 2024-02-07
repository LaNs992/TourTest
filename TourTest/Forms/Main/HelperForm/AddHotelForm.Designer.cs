namespace TourTest.Forms.Main.HelperForm
{
    partial class AddHotelForm
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownStars = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCountri = new System.Windows.Forms.ComboBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStars)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(128, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(276, 23);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // numericUpDownStars
            // 
            this.numericUpDownStars.Location = new System.Drawing.Point(128, 123);
            this.numericUpDownStars.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownStars.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStars.Name = "numericUpDownStars";
            this.numericUpDownStars.ReadOnly = true;
            this.numericUpDownStars.Size = new System.Drawing.Size(276, 23);
            this.numericUpDownStars.TabIndex = 1;
            this.numericUpDownStars.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStars.ValueChanged += new System.EventHandler(this.numericUpDownStars_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название Отеля";
            // 
            // comboBoxCountri
            // 
            this.comboBoxCountri.FormattingEnabled = true;
            this.comboBoxCountri.Location = new System.Drawing.Point(128, 164);
            this.comboBoxCountri.Name = "comboBoxCountri";
            this.comboBoxCountri.Size = new System.Drawing.Size(276, 23);
            this.comboBoxCountri.TabIndex = 3;
            this.comboBoxCountri.SelectedIndexChanged += new System.EventHandler(this.comboBoxCountri_SelectedIndexChanged);
            // 
            // butAdd
            // 
            this.butAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.butAdd.Location = new System.Drawing.Point(34, 209);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(116, 39);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "Сохранить";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxDesc
            // 
            this.textBoxDesc.Location = new System.Drawing.Point(128, 79);
            this.textBoxDesc.Name = "textBoxDesc";
            this.textBoxDesc.Size = new System.Drawing.Size(276, 23);
            this.textBoxDesc.TabIndex = 5;
            this.textBoxDesc.TextChanged += new System.EventHandler(this.textBoxDesc_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кол-во звезд";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Страна";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(288, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = " Отменить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddHotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 260);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.comboBoxCountri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownStars);
            this.Controls.Add(this.textBoxName);
            this.Name = "AddHotelForm";
            this.Text = "AddHotelForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxName;
        private NumericUpDown numericUpDownStars;
        private Label label1;
        private ComboBox comboBoxCountri;
        private Button butAdd;
        private TextBox textBoxDesc;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
    }
}