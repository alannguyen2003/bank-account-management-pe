namespace PRN211PE_SU22_HoDuongTrungNguyen
{
    partial class Management
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
            dgvBankAccount = new DataGridView();
            lblMessage = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAccountId = new TextBox();
            txtBranch = new TextBox();
            txtAccountName = new TextBox();
            cbType = new ComboBox();
            btnCreate = new Button();
            dtpDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).BeginInit();
            SuspendLayout();
            // 
            // dgvBankAccount
            // 
            dgvBankAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBankAccount.Location = new Point(12, 35);
            dgvBankAccount.Name = "dgvBankAccount";
            dgvBankAccount.RowHeadersWidth = 51;
            dgvBankAccount.RowTemplate.Height = 29;
            dgvBankAccount.Size = new Size(928, 343);
            dgvBankAccount.TabIndex = 0;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(12, 9);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(138, 20);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "Bank Account Table";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 415);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "AccountId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 457);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 3;
            label2.Text = "AccountName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 535);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 4;
            label3.Text = "BranchName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 496);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 5;
            label4.Text = "Year of open";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 577);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 6;
            label5.Text = "Type";
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(189, 412);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(248, 27);
            txtAccountId.TabIndex = 7;
            // 
            // txtBranch
            // 
            txtBranch.Location = new Point(189, 532);
            txtBranch.Name = "txtBranch";
            txtBranch.Size = new Size(248, 27);
            txtBranch.TabIndex = 8;
            // 
            // txtAccountName
            // 
            txtAccountName.Location = new Point(189, 454);
            txtAccountName.Name = "txtAccountName";
            txtAccountName.Size = new Size(248, 27);
            txtAccountName.TabIndex = 10;
            // 
            // cbType
            // 
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(189, 574);
            cbType.Name = "cbType";
            cbType.Size = new Size(248, 28);
            cbType.TabIndex = 11;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(154, 631);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(189, 491);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(248, 27);
            dtpDate.TabIndex = 14;
            // 
            // Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 712);
            Controls.Add(dtpDate);
            Controls.Add(btnCreate);
            Controls.Add(cbType);
            Controls.Add(txtAccountName);
            Controls.Add(txtBranch);
            Controls.Add(txtAccountId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMessage);
            Controls.Add(dgvBankAccount);
            Name = "Management";
            Text = "Management";
            ((System.ComponentModel.ISupportInitialize)dgvBankAccount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBankAccount;
        private Label lblMessage;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAccountId;
        private TextBox txtBranch;
        private TextBox txtAccountName;
        private ComboBox cbType;
        private Button btnCreate;
        private DateTimePicker dtpDate;
    }
}