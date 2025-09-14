using System.Drawing;
using System.Windows.Forms;

namespace BankAccountsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerTxt = new System.Windows.Forms.TextBox();
            this.AmountNum = new System.Windows.Forms.NumericUpDown();
            this.BankAccountsGrid = new System.Windows.Forms.DataGridView();
            this.DepositBtn = new System.Windows.Forms.Button();
            this.WithdrawBtn = new System.Windows.Forms.Button();
            this.CreateAccountBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.InterestRateNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 276);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount:";
            // 
            // OwnerTxt
            // 
            this.OwnerTxt.Location = new System.Drawing.Point(123, 35);
            this.OwnerTxt.Name = "OwnerTxt";
            this.OwnerTxt.Size = new System.Drawing.Size(229, 42);
            this.OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            this.AmountNum.Location = new System.Drawing.Point(150, 276);
            this.AmountNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.AmountNum.Minimum = new decimal(new int[] {
            9999999,
            0,
            0,
            -2147483648});
            this.AmountNum.Name = "AmountNum";
            this.AmountNum.Size = new System.Drawing.Size(215, 42);
            this.AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            this.BankAccountsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BankAccountsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BankAccountsGrid.Location = new System.Drawing.Point(411, 35);
            this.BankAccountsGrid.Name = "BankAccountsGrid";
            this.BankAccountsGrid.RowHeadersWidth = 51;
            this.BankAccountsGrid.Size = new System.Drawing.Size(503, 219);
            this.BankAccountsGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            this.DepositBtn.Location = new System.Drawing.Point(411, 264);
            this.DepositBtn.Name = "DepositBtn";
            this.DepositBtn.Size = new System.Drawing.Size(247, 54);
            this.DepositBtn.TabIndex = 5;
            this.DepositBtn.Text = "Deposit";
            this.DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            this.WithdrawBtn.Location = new System.Drawing.Point(664, 264);
            this.WithdrawBtn.Name = "WithdrawBtn";
            this.WithdrawBtn.Size = new System.Drawing.Size(250, 54);
            this.WithdrawBtn.TabIndex = 6;
            this.WithdrawBtn.Text = "Withdraw";
            this.WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            this.CreateAccountBtn.Location = new System.Drawing.Point(123, 137);
            this.CreateAccountBtn.Name = "CreateAccountBtn";
            this.CreateAccountBtn.Size = new System.Drawing.Size(229, 54);
            this.CreateAccountBtn.TabIndex = 7;
            this.CreateAccountBtn.Text = "Create account";
            this.CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interest rate (%):";
            // 
            // InterestRateNum
            // 
            this.InterestRateNum.Location = new System.Drawing.Point(238, 89);
            this.InterestRateNum.Name = "InterestRateNum";
            this.InterestRateNum.Size = new System.Drawing.Size(114, 42);
            this.InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 330);
            this.Controls.Add(this.InterestRateNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateAccountBtn);
            this.Controls.Add(this.WithdrawBtn);
            this.Controls.Add(this.DepositBtn);
            this.Controls.Add(this.BankAccountsGrid);
            this.Controls.Add(this.AmountNum);
            this.Controls.Add(this.OwnerTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AmountNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankAccountsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}