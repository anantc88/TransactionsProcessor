using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Configuration;
namespace TestTask.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ProgressBar progressBar1;
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
            dataGridViewTransactions = new DataGridView();
            buttonProcess = new Button();
            buttonCancel = new Button();
            progressBar1 = new ProgressBar();
            lblNumOfRecordsProcessed = new Label();
            lblTotalUploaded = new Label();
            lblPercentage = new Label();
            ((ISupportInitialize)dataGridViewTransactions).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTransactions
            // 
            dataGridViewTransactions.AllowUserToDeleteRows = false;
            dataGridViewTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTransactions.Location = new Point(12, 12);
            dataGridViewTransactions.Name = "dataGridViewTransactions";
            dataGridViewTransactions.ReadOnly = true;
            dataGridViewTransactions.RowHeadersWidth = 62;
            dataGridViewTransactions.Size = new Size(1200, 376);
            dataGridViewTransactions.TabIndex = 0;
            // 
            // buttonProcess
            // 
            buttonProcess.Location = new Point(12, 404);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(94, 29);
            buttonProcess.TabIndex = 1;
            buttonProcess.Text = "Process";
            buttonProcess.UseVisualStyleBackColor = true;
            buttonProcess.Click += buttonProcess_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Enabled = false;
            buttonCancel.Location = new Point(112, 404);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(212, 404);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(976, 29);
            progressBar1.TabIndex = 3;
            // 
            // lblNumOfRecordsProcessed
            // 
            lblNumOfRecordsProcessed.AutoSize = true;
            lblNumOfRecordsProcessed.Location = new Point(215, 444);
            lblNumOfRecordsProcessed.Name = "lblNumOfRecordsProcessed";
            lblNumOfRecordsProcessed.Size = new Size(96, 25);
            lblNumOfRecordsProcessed.TabIndex = 4;
            lblNumOfRecordsProcessed.Text = "Processed:";
            // 
            // lblTotalUploaded
            // 
            lblTotalUploaded.AutoSize = true;
            lblTotalUploaded.Location = new Point(216, 476);
            lblTotalUploaded.Name = "lblTotalUploaded";
            lblTotalUploaded.Size = new Size(138, 25);
            lblTotalUploaded.TabIndex = 5;
            lblTotalUploaded.Text = "Total Uploaded:";
            // 
            // lblPercentage
            // 
            lblPercentage.AutoSize = true;
            lblPercentage.Location = new Point(217, 504);
            lblPercentage.Name = "lblPercentage";
            lblPercentage.Size = new Size(141, 25);
            lblPercentage.TabIndex = 6;
            lblPercentage.Text = "%age Uploaded:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 550);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Controls.Add(lblPercentage);
            Controls.Add(lblTotalUploaded);
            Controls.Add(lblNumOfRecordsProcessed);
            Controls.Add(progressBar1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonProcess);
            Controls.Add(dataGridViewTransactions);
            Name = "MainForm";
            Text = "Transactions Processor";
            ((ISupportInitialize)dataGridViewTransactions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumOfRecordsProcessed;
        private Label lblTotalUploaded;
        private Label lblPercentage;
    }
}