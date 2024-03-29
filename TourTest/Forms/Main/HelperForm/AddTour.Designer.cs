﻿namespace TourTest.Forms.Main.HelperForm
{
    partial class AddTour
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
            this.label3 = new System.Windows.Forms.Label();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.isActualChecked = new System.Windows.Forms.CheckBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.ticketsNumeric = new System.Windows.Forms.NumericUpDown();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Описание";
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(136, 274);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(254, 69);
            this.descTextBox.TabIndex = 32;
            this.descTextBox.TextChanged += new System.EventHandler(this.descTextBox_TextChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(80)))), ((int)(((byte)(86)))));
            this.deleteButton.DialogResult = System.Windows.Forms.DialogResult.No;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(18, 473);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(371, 30);
            this.deleteButton.TabIndex = 31;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Visible = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(18, 437);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(371, 30);
            this.cancelButton.TabIndex = 30;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.addButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(18, 401);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(371, 30);
            this.addButton.TabIndex = 29;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(19, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Тип туризма";
            // 
            // isActualChecked
            // 
            this.isActualChecked.AutoSize = true;
            this.isActualChecked.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isActualChecked.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.isActualChecked.Location = new System.Drawing.Point(269, 360);
            this.isActualChecked.Name = "isActualChecked";
            this.isActualChecked.Size = new System.Drawing.Size(101, 27);
            this.isActualChecked.TabIndex = 26;
            this.isActualChecked.Text = "Актуален";
            this.isActualChecked.UseVisualStyleBackColor = true;
            this.isActualChecked.CheckedChanged += new System.EventHandler(this.isActualChecked_CheckedChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(196, 132);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(194, 23);
            this.countryComboBox.TabIndex = 24;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBox_SelectedIndexChanged);
            // 
            // ticketsNumeric
            // 
            this.ticketsNumeric.Location = new System.Drawing.Point(196, 93);
            this.ticketsNumeric.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ticketsNumeric.Name = "ticketsNumeric";
            this.ticketsNumeric.ReadOnly = true;
            this.ticketsNumeric.Size = new System.Drawing.Size(194, 23);
            this.ticketsNumeric.TabIndex = 23;
            this.ticketsNumeric.ValueChanged += new System.EventHandler(this.ticketsNumeric_ValueChanged);
            // 
            // costTextBox
            // 
            this.costTextBox.Location = new System.Drawing.Point(136, 48);
            this.costTextBox.Multiline = true;
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(254, 30);
            this.costTextBox.TabIndex = 22;
            this.costTextBox.TextChanged += new System.EventHandler(this.costTextBox_TextChanged);
            this.costTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costTextBox_KeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(135, 12);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 30);
            this.nameTextBox.TabIndex = 21;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Страна пребывания";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.Location = new System.Drawing.Point(19, 93);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(153, 23);
            this.amountLabel.TabIndex = 19;
            this.amountLabel.Text = "Билеты в наличии";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.costLabel.Location = new System.Drawing.Point(19, 48);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(92, 23);
            this.costLabel.TabIndex = 18;
            this.costLabel.Text = "Стоимость";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(19, 12);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(80, 23);
            this.nameLabel.TabIndex = 17;
            this.nameLabel.Text = "Название";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(136, 174);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(254, 94);
            this.checkedListBox1.TabIndex = 34;
            // 
            // AddTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 522);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isActualChecked);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.ticketsNumeric);
            this.Controls.Add(this.costTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddTour";
            this.Load += new System.EventHandler(this.AddTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketsNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private TextBox descTextBox;
        private Button deleteButton;
        private Button cancelButton;
        private Button addButton;
        private Label label2;
        private CheckBox isActualChecked;
        private ComboBox countryComboBox;
        private NumericUpDown ticketsNumeric;
        private TextBox costTextBox;
        private TextBox nameTextBox;
        private Label label1;
        private Label amountLabel;
        private Label costLabel;
        private Label nameLabel;
        private CheckedListBox checkedListBox1;
    }
}