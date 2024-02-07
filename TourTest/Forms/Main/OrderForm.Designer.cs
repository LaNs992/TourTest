namespace TourTest.Forms.Main
{
    partial class OrderForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.butZakaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.seil = new System.Windows.Forms.Label();
            this.PeiceLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 34);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(966, 314);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пункт получения";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(12, 387);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(242, 23);
            this.comboBox.TabIndex = 1;
            // 
            // butZakaz
            // 
            this.butZakaz.Location = new System.Drawing.Point(12, 416);
            this.butZakaz.Name = "butZakaz";
            this.butZakaz.Size = new System.Drawing.Size(141, 23);
            this.butZakaz.TabIndex = 2;
            this.butZakaz.Text = "Оформить заказ";
            this.butZakaz.UseVisualStyleBackColor = true;
            this.butZakaz.Click += new System.EventHandler(this.butZakaz_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(498, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сумма заказа:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(498, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма скидки:";
            // 
            // seil
            // 
            this.seil.AutoSize = true;
            this.seil.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.seil.Location = new System.Drawing.Point(615, 418);
            this.seil.Name = "seil";
            this.seil.Size = new System.Drawing.Size(19, 21);
            this.seil.TabIndex = 6;
            this.seil.Text = "0";
            // 
            // PeiceLbl
            // 
            this.PeiceLbl.AutoSize = true;
            this.PeiceLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PeiceLbl.Location = new System.Drawing.Point(615, 390);
            this.PeiceLbl.Name = "PeiceLbl";
            this.PeiceLbl.Size = new System.Drawing.Size(19, 21);
            this.PeiceLbl.TabIndex = 7;
            this.PeiceLbl.Text = "0";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.PeiceLbl);
            this.Controls.Add(this.seil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.butZakaz);
            this.Controls.Add(this.comboBox);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox comboBox;
        private Button butZakaz;
        private Label label2;
        private Label label3;
        private Label seil;
        private Label PeiceLbl;
    }
}