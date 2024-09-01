namespace TestTask.View
{
    partial class TransactionDetailForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            txtBalanceAfterTheTransaction = new TextBox();
            txtTransactionAmountInAccountCurrency = new TextBox();
            txtTransactionDateTime = new TextBox();
            txtAccountCurrency = new TextBox();
            txtTransactionAmountCurrency = new TextBox();
            txtTypeOfTransaction = new TextBox();
            txtTransactionAmount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            txtAccountNumber = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtBalanceAfterTheTransaction, 1, 7);
            tableLayoutPanel1.Controls.Add(txtTransactionAmountInAccountCurrency, 1, 6);
            tableLayoutPanel1.Controls.Add(txtTransactionDateTime, 1, 5);
            tableLayoutPanel1.Controls.Add(txtAccountCurrency, 1, 4);
            tableLayoutPanel1.Controls.Add(txtTransactionAmountCurrency, 1, 3);
            tableLayoutPanel1.Controls.Add(txtTypeOfTransaction, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTransactionAmount, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(txtAccountNumber, 1, 0);
            tableLayoutPanel1.Location = new Point(93, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(572, 430);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // txtBalanceAfterTheTransaction
            // 
            txtBalanceAfterTheTransaction.Enabled = false;
            txtBalanceAfterTheTransaction.Location = new Point(289, 374);
            txtBalanceAfterTheTransaction.Name = "txtBalanceAfterTheTransaction";
            txtBalanceAfterTheTransaction.ReadOnly = true;
            txtBalanceAfterTheTransaction.Size = new Size(280, 31);
            txtBalanceAfterTheTransaction.TabIndex = 15;
            // 
            // txtTransactionAmountInAccountCurrency
            // 
            txtTransactionAmountInAccountCurrency.Enabled = false;
            txtTransactionAmountInAccountCurrency.Location = new Point(289, 321);
            txtTransactionAmountInAccountCurrency.Name = "txtTransactionAmountInAccountCurrency";
            txtTransactionAmountInAccountCurrency.ReadOnly = true;
            txtTransactionAmountInAccountCurrency.Size = new Size(280, 31);
            txtTransactionAmountInAccountCurrency.TabIndex = 14;
            // 
            // txtTransactionDateTime
            // 
            txtTransactionDateTime.Enabled = false;
            txtTransactionDateTime.Location = new Point(289, 268);
            txtTransactionDateTime.Name = "txtTransactionDateTime";
            txtTransactionDateTime.ReadOnly = true;
            txtTransactionDateTime.Size = new Size(280, 31);
            txtTransactionDateTime.TabIndex = 13;
            // 
            // txtAccountCurrency
            // 
            txtAccountCurrency.Enabled = false;
            txtAccountCurrency.Location = new Point(289, 215);
            txtAccountCurrency.Name = "txtAccountCurrency";
            txtAccountCurrency.ReadOnly = true;
            txtAccountCurrency.Size = new Size(280, 31);
            txtAccountCurrency.TabIndex = 12;
            // 
            // txtTransactionAmountCurrency
            // 
            txtTransactionAmountCurrency.Enabled = false;
            txtTransactionAmountCurrency.Location = new Point(289, 162);
            txtTransactionAmountCurrency.Name = "txtTransactionAmountCurrency";
            txtTransactionAmountCurrency.ReadOnly = true;
            txtTransactionAmountCurrency.Size = new Size(280, 31);
            txtTransactionAmountCurrency.TabIndex = 11;
            // 
            // txtTypeOfTransaction
            // 
            txtTypeOfTransaction.Enabled = false;
            txtTypeOfTransaction.Location = new Point(289, 109);
            txtTypeOfTransaction.Name = "txtTypeOfTransaction";
            txtTypeOfTransaction.ReadOnly = true;
            txtTypeOfTransaction.Size = new Size(280, 31);
            txtTypeOfTransaction.TabIndex = 10;
            // 
            // txtTransactionAmount
            // 
            txtTransactionAmount.Enabled = false;
            txtTransactionAmount.Location = new Point(289, 56);
            txtTransactionAmount.Name = "txtTransactionAmount";
            txtTransactionAmount.ReadOnly = true;
            txtTransactionAmount.Size = new Size(280, 31);
            txtTransactionAmount.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Account Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 1;
            label2.Text = "Transaction Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 212);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 4;
            label5.Text = "Account Currency";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 318);
            label7.Name = "label7";
            label7.Size = new Size(244, 25);
            label7.TabIndex = 6;
            label7.Text = "Transaction Amount Updated";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 371);
            label8.Name = "label8";
            label8.Size = new Size(159, 25);
            label8.TabIndex = 7;
            label8.Text = "Balance Remaining";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 106);
            label3.Name = "label3";
            label3.Size = new Size(142, 25);
            label3.TabIndex = 2;
            label3.Text = "Transaction Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 159);
            label4.Name = "label4";
            label4.Size = new Size(174, 25);
            label4.TabIndex = 3;
            label4.Text = "Transaction Currency";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 265);
            label6.Name = "label6";
            label6.Size = new Size(180, 25);
            label6.TabIndex = 5;
            label6.Text = "Transaction DateTime";
            // 
            // txtAccountNumber
            // 
            txtAccountNumber.Enabled = false;
            txtAccountNumber.Location = new Point(289, 3);
            txtAccountNumber.Name = "txtAccountNumber";
            txtAccountNumber.ReadOnly = true;
            txtAccountNumber.Size = new Size(280, 31);
            txtAccountNumber.TabIndex = 8;
            // 
            // TransactionDetailForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 471);
            Controls.Add(tableLayoutPanel1);
            Name = "TransactionDetailForm";
            Text = "Transaction Details";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtBalanceAfterTheTransaction;
        private TextBox txtTransactionAmountInAccountCurrency;
        private TextBox txtTransactionDateTime;
        private TextBox txtAccountCurrency;
        private TextBox txtTransactionAmountCurrency;
        private TextBox txtTypeOfTransaction;
        private TextBox txtTransactionAmount;
        private TextBox txtAccountNumber;
    }
}