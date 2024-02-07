namespace TourTest.Forms.Main
{
    partial class TourForms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOrder = new System.Windows.Forms.Button();
            this.CountCorLbl = new System.Windows.Forms.Label();
            this.Moneylbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AllSumm = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.isActualcheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.butOrder);
            this.panel1.Controls.Add(this.CountCorLbl);
            this.panel1.Controls.Add(this.Moneylbl);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.AllSumm);
            this.panel1.Controls.Add(this.Namelbl);
            this.panel1.Controls.Add(this.buttonAuto);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.isActualcheckBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.searchLabel);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 160);
            this.panel1.TabIndex = 1;
            // 
            // butOrder
            // 
            this.butOrder.BackColor = System.Drawing.Color.RoyalBlue;
            this.butOrder.FlatAppearance.BorderSize = 0;
            this.butOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.butOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.butOrder.Location = new System.Drawing.Point(279, 108);
            this.butOrder.Name = "butOrder";
            this.butOrder.Size = new System.Drawing.Size(117, 33);
            this.butOrder.TabIndex = 14;
            this.butOrder.Text = "КОРЗИНА";
            this.butOrder.UseVisualStyleBackColor = false;
            this.butOrder.Click += new System.EventHandler(this.butOrder_Click);
            // 
            // CountCorLbl
            // 
            this.CountCorLbl.AutoSize = true;
            this.CountCorLbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CountCorLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountCorLbl.Location = new System.Drawing.Point(279, 79);
            this.CountCorLbl.Name = "CountCorLbl";
            this.CountCorLbl.Size = new System.Drawing.Size(99, 19);
            this.CountCorLbl.TabIndex = 13;
            this.CountCorLbl.Text = "В корзине:";
            // 
            // Moneylbl
            // 
            this.Moneylbl.AutoSize = true;
            this.Moneylbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Moneylbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Moneylbl.Location = new System.Drawing.Point(279, 51);
            this.Moneylbl.Name = "Moneylbl";
            this.Moneylbl.Size = new System.Drawing.Size(117, 19);
            this.Moneylbl.TabIndex = 12;
            this.Moneylbl.Text = "Цена заказа:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(560, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "ОТЕЛИ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllSumm
            // 
            this.AllSumm.AutoSize = true;
            this.AllSumm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AllSumm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AllSumm.Location = new System.Drawing.Point(560, 18);
            this.AllSumm.Name = "AllSumm";
            this.AllSumm.Size = new System.Drawing.Size(108, 19);
            this.AllSumm.TabIndex = 10;
            this.AllSumm.Text = "Общая сумма";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Namelbl.Location = new System.Drawing.Point(12, 9);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(117, 19);
            this.Namelbl.TabIndex = 9;
            this.Namelbl.Text = "Пользователь";
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAuto.FlatAppearance.BorderSize = 0;
            this.buttonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuto.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAuto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAuto.Location = new System.Drawing.Point(560, 90);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(138, 33);
            this.buttonAuto.TabIndex = 8;
            this.buttonAuto.Text = "ДОБАВИТЬ ТУРЫ";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(313, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "TRAVSTAR";
            // 
            // isActualcheckBox
            // 
            this.isActualcheckBox.AutoSize = true;
            this.isActualcheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActualcheckBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.isActualcheckBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.isActualcheckBox.Location = new System.Drawing.Point(12, 108);
            this.isActualcheckBox.Name = "isActualcheckBox";
            this.isActualcheckBox.Size = new System.Drawing.Size(226, 23);
            this.isActualcheckBox.TabIndex = 5;
            this.isActualcheckBox.Text = "Только актуальные туры";
            this.isActualcheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 22);
            this.comboBox1.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchLabel.Location = new System.Drawing.Point(14, 51);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(63, 19);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Поиск:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(83, 52);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(155, 22);
            this.searchTextBox.TabIndex = 0;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoScroll = true;
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(25, 156);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(713, 446);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // TourForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 683);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bauhaus 93", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "TourForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TourForms";
            this.Load += new System.EventHandler(this.TourForms_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private CheckBox isActualcheckBox;
        private ComboBox comboBox1;
        private Label searchLabel;
        private TextBox searchTextBox;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private Button buttonAuto;
        private Label Namelbl;
        private Label AllSumm;
        private Button button1;
        private Label CountCorLbl;
        private Label Moneylbl;
        private Button butOrder;
    }
}