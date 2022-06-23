namespace Calculator
{
    partial class MainCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainCalculator));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.label1 = new System.Windows.Forms.Label();
            this.uiAmountTexbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uiItemNameTextbox = new System.Windows.Forms.TextBox();
            this.uiDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiSpendButton = new System.Windows.Forms.Button();
            this.uiTotalSpentTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uiTotalLuxTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uiTotalEssTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.uiMoneyLeftTextbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.uiTotalIncomeTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uiIncomeTextBox = new System.Windows.Forms.TextBox();
            this.uiIncomeButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uiTransactionDataGrid = new System.Windows.Forms.DataGridView();
            this.column_DataAdded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_transactionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTransactionDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Amount";
            // 
            // uiAmountTexbox
            // 
            this.uiAmountTexbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiAmountTexbox.Location = new System.Drawing.Point(10, 31);
            this.uiAmountTexbox.Multiline = true;
            this.uiAmountTexbox.Name = "uiAmountTexbox";
            this.uiAmountTexbox.Size = new System.Drawing.Size(100, 20);
            this.uiAmountTexbox.TabIndex = 1;
            this.uiAmountTexbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_NUM_ONLY);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name of Thing\r\n";
            // 
            // uiItemNameTextbox
            // 
            this.uiItemNameTextbox.Location = new System.Drawing.Point(131, 31);
            this.uiItemNameTextbox.Multiline = true;
            this.uiItemNameTextbox.Name = "uiItemNameTextbox";
            this.uiItemNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.uiItemNameTextbox.TabIndex = 3;
            this.uiItemNameTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_CHAR_ONLY);
            // 
            // uiDropdown
            // 
            this.uiDropdown.FormattingEnabled = true;
            this.uiDropdown.Items.AddRange(new object[] {
            "Luxury",
            "Essential"});
            this.uiDropdown.Location = new System.Drawing.Point(255, 31);
            this.uiDropdown.Name = "uiDropdown";
            this.uiDropdown.Size = new System.Drawing.Size(100, 21);
            this.uiDropdown.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Luxury or Essential";
            // 
            // uiSpendButton
            // 
            this.uiSpendButton.BackColor = System.Drawing.SystemColors.Control;
            this.uiSpendButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.uiSpendButton.FlatAppearance.BorderSize = 0;
            this.uiSpendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSpendButton.Location = new System.Drawing.Point(376, 18);
            this.uiSpendButton.Name = "uiSpendButton";
            this.uiSpendButton.Size = new System.Drawing.Size(89, 31);
            this.uiSpendButton.TabIndex = 6;
            this.uiSpendButton.Text = "Confirm";
            this.uiSpendButton.UseVisualStyleBackColor = false;
            this.uiSpendButton.Click += new System.EventHandler(this.uiSpendButton_Click);
            // 
            // uiTotalSpentTextbox
            // 
            this.uiTotalSpentTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiTotalSpentTextbox.Location = new System.Drawing.Point(38, 43);
            this.uiTotalSpentTextbox.Multiline = true;
            this.uiTotalSpentTextbox.Name = "uiTotalSpentTextbox";
            this.uiTotalSpentTextbox.ReadOnly = true;
            this.uiTotalSpentTextbox.Size = new System.Drawing.Size(100, 49);
            this.uiTotalSpentTextbox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "In Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "On Luxuries";
            // 
            // uiTotalLuxTextbox
            // 
            this.uiTotalLuxTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiTotalLuxTextbox.Location = new System.Drawing.Point(187, 43);
            this.uiTotalLuxTextbox.Multiline = true;
            this.uiTotalLuxTextbox.Name = "uiTotalLuxTextbox";
            this.uiTotalLuxTextbox.ReadOnly = true;
            this.uiTotalLuxTextbox.Size = new System.Drawing.Size(100, 49);
            this.uiTotalLuxTextbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(331, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "On Essentials";
            // 
            // uiTotalEssTextbox
            // 
            this.uiTotalEssTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiTotalEssTextbox.Location = new System.Drawing.Point(333, 44);
            this.uiTotalEssTextbox.Multiline = true;
            this.uiTotalEssTextbox.Name = "uiTotalEssTextbox";
            this.uiTotalEssTextbox.ReadOnly = true;
            this.uiTotalEssTextbox.Size = new System.Drawing.Size(100, 49);
            this.uiTotalEssTextbox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(33, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Money Left in Budget";
            // 
            // uiMoneyLeftTextbox
            // 
            this.uiMoneyLeftTextbox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiMoneyLeftTextbox.Location = new System.Drawing.Point(36, 45);
            this.uiMoneyLeftTextbox.Multiline = true;
            this.uiMoneyLeftTextbox.Name = "uiMoneyLeftTextbox";
            this.uiMoneyLeftTextbox.ReadOnly = true;
            this.uiMoneyLeftTextbox.Size = new System.Drawing.Size(100, 49);
            this.uiMoneyLeftTextbox.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox1.Controls.Add(this.uiTotalSpentTextbox);
            this.groupBox1.Controls.Add(this.uiTotalLuxTextbox);
            this.groupBox1.Controls.Add(this.uiTotalEssTextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 330);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(487, 105);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Money spent...";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.uiMoneyLeftTextbox);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.uiTotalIncomeTextBox);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(14, 440);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 109);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 29;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // uiTotalIncomeTextBox
            // 
            this.uiTotalIncomeTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.uiTotalIncomeTextBox.Location = new System.Drawing.Point(185, 45);
            this.uiTotalIncomeTextBox.Multiline = true;
            this.uiTotalIncomeTextBox.Name = "uiTotalIncomeTextBox";
            this.uiTotalIncomeTextBox.ReadOnly = true;
            this.uiTotalIncomeTextBox.Size = new System.Drawing.Size(100, 49);
            this.uiTotalIncomeTextBox.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(182, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "This Week\'s Budget";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(313, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Weekly Budget Calculator";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 57);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "Enter Weekly Income:";
            // 
            // uiIncomeTextBox
            // 
            this.uiIncomeTextBox.Location = new System.Drawing.Point(133, 54);
            this.uiIncomeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.uiIncomeTextBox.Name = "uiIncomeTextBox";
            this.uiIncomeTextBox.Size = new System.Drawing.Size(99, 20);
            this.uiIncomeTextBox.TabIndex = 23;
            this.uiIncomeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTB_NUM_ONLY);
            // 
            // uiIncomeButton
            // 
            this.uiIncomeButton.BackColor = System.Drawing.SystemColors.Control;
            this.uiIncomeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.uiIncomeButton.FlatAppearance.BorderSize = 0;
            this.uiIncomeButton.Location = new System.Drawing.Point(257, 47);
            this.uiIncomeButton.Name = "uiIncomeButton";
            this.uiIncomeButton.Size = new System.Drawing.Size(89, 31);
            this.uiIncomeButton.TabIndex = 25;
            this.uiIncomeButton.Text = "Confirm";
            this.uiIncomeButton.UseVisualStyleBackColor = false;
            this.uiIncomeButton.Click += new System.EventHandler(this.uiIncomeButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.groupBox2.Controls.Add(this.uiDropdown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.uiAmountTexbox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.uiItemNameTextbox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.uiSpendButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(487, 65);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Record Spending";
            // 
            // uiTransactionDataGrid
            // 
            this.uiTransactionDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiTransactionDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_DataAdded,
            this.column_transactionName,
            this.column_Amount,
            this.column_TransactionType});
            this.uiTransactionDataGrid.Location = new System.Drawing.Point(12, 163);
            this.uiTransactionDataGrid.Name = "uiTransactionDataGrid";
            this.uiTransactionDataGrid.Size = new System.Drawing.Size(487, 150);
            this.uiTransactionDataGrid.TabIndex = 29;
            // 
            // column_DataAdded
            // 
            this.column_DataAdded.HeaderText = "Date Added";
            this.column_DataAdded.Name = "column_DataAdded";
            this.column_DataAdded.ReadOnly = true;
            this.column_DataAdded.Width = 140;
            // 
            // column_transactionName
            // 
            this.column_transactionName.HeaderText = "Name of Transaction";
            this.column_transactionName.Name = "column_transactionName";
            this.column_transactionName.ReadOnly = true;
            // 
            // column_Amount
            // 
            this.column_Amount.HeaderText = "Amount (£)";
            this.column_Amount.Name = "column_Amount";
            this.column_Amount.ReadOnly = true;
            // 
            // column_TransactionType
            // 
            this.column_TransactionType.HeaderText = "Transaction type";
            this.column_TransactionType.Name = "column_TransactionType";
            this.column_TransactionType.ReadOnly = true;
            this.column_TransactionType.Width = 102;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 68);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // MainCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(513, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.uiTransactionDataGrid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.uiIncomeButton);
            this.Controls.Add(this.uiIncomeTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainCalculator";
            this.Text = "Weekly Budget Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiTransactionDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiAmountTexbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiItemNameTextbox;
        private System.Windows.Forms.ComboBox uiDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiSpendButton;
        private System.Windows.Forms.TextBox uiTotalSpentTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uiTotalLuxTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uiTotalEssTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uiMoneyLeftTextbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uiIncomeTextBox;
        private System.Windows.Forms.Button uiIncomeButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox uiTotalIncomeTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView uiTransactionDataGrid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_DataAdded;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_transactionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_TransactionType;
    }
}

