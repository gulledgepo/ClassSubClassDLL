namespace Week1Assignment1
{
    partial class BankingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankingApp));
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSavings = new System.Windows.Forms.RadioButton();
            this.rdbChecking = new System.Windows.Forms.RadioButton();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblServiceOrMin = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.chkFreeChecking = new System.Windows.Forms.CheckBox();
            this.chkFreeChecks = new System.Windows.Forms.CheckBox();
            this.chkCancelled = new System.Windows.Forms.CheckBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtServiceOrMin = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(24, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(96, 18);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(24, 55);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(88, 18);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSavings);
            this.groupBox1.Controls.Add(this.rdbChecking);
            this.groupBox1.Location = new System.Drawing.Point(12, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AccountType";
            // 
            // rdbSavings
            // 
            this.rdbSavings.AutoSize = true;
            this.rdbSavings.Location = new System.Drawing.Point(106, 19);
            this.rdbSavings.Name = "rdbSavings";
            this.rdbSavings.Size = new System.Drawing.Size(63, 17);
            this.rdbSavings.TabIndex = 1;
            this.rdbSavings.Text = "Savings";
            this.rdbSavings.UseVisualStyleBackColor = true;
            this.rdbSavings.CheckedChanged += new System.EventHandler(this.rdbSavings_CheckedChanged);
            // 
            // rdbChecking
            // 
            this.rdbChecking.AutoSize = true;
            this.rdbChecking.Checked = true;
            this.rdbChecking.Location = new System.Drawing.Point(15, 19);
            this.rdbChecking.Name = "rdbChecking";
            this.rdbChecking.Size = new System.Drawing.Size(70, 17);
            this.rdbChecking.TabIndex = 0;
            this.rdbChecking.TabStop = true;
            this.rdbChecking.Text = "Checking";
            this.rdbChecking.UseVisualStyleBackColor = true;
            this.rdbChecking.CheckedChanged += new System.EventHandler(this.rdbChecking_CheckedChanged);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(24, 87);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(144, 18);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Checking Balance:";
            // 
            // lblServiceOrMin
            // 
            this.lblServiceOrMin.AutoSize = true;
            this.lblServiceOrMin.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceOrMin.Location = new System.Drawing.Point(24, 118);
            this.lblServiceOrMin.Name = "lblServiceOrMin";
            this.lblServiceOrMin.Size = new System.Drawing.Size(128, 18);
            this.lblServiceOrMin.TabIndex = 5;
            this.lblServiceOrMin.Text = "Service Charge:";
            // 
            // lblInterestRate
            // 
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterestRate.Location = new System.Drawing.Point(24, 154);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Size = new System.Drawing.Size(120, 18);
            this.lblInterestRate.TabIndex = 6;
            this.lblInterestRate.Text = "Interest Rate:";
            this.lblInterestRate.Visible = false;
            // 
            // chkFreeChecking
            // 
            this.chkFreeChecking.AutoSize = true;
            this.chkFreeChecking.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFreeChecking.Location = new System.Drawing.Point(27, 193);
            this.chkFreeChecking.Name = "chkFreeChecking";
            this.chkFreeChecking.Size = new System.Drawing.Size(131, 22);
            this.chkFreeChecking.TabIndex = 7;
            this.chkFreeChecking.Text = "Free Checking";
            this.chkFreeChecking.UseVisualStyleBackColor = true;
            // 
            // chkFreeChecks
            // 
            this.chkFreeChecks.AutoSize = true;
            this.chkFreeChecks.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFreeChecks.Location = new System.Drawing.Point(27, 221);
            this.chkFreeChecks.Name = "chkFreeChecks";
            this.chkFreeChecks.Size = new System.Drawing.Size(115, 22);
            this.chkFreeChecks.TabIndex = 8;
            this.chkFreeChecks.Text = "Free Checks";
            this.chkFreeChecks.UseVisualStyleBackColor = true;
            // 
            // chkCancelled
            // 
            this.chkCancelled.AutoSize = true;
            this.chkCancelled.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCancelled.Location = new System.Drawing.Point(27, 249);
            this.chkCancelled.Name = "chkCancelled";
            this.chkCancelled.Size = new System.Drawing.Size(227, 22);
            this.chkCancelled.TabIndex = 9;
            this.chkCancelled.Text = "Cancelled Checks Returned";
            this.chkCancelled.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(182, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtFirstName.TabIndex = 10;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(182, 55);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 11;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(182, 87);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(145, 20);
            this.txtBalance.TabIndex = 13;
            // 
            // txtServiceOrMin
            // 
            this.txtServiceOrMin.Location = new System.Drawing.Point(182, 118);
            this.txtServiceOrMin.Name = "txtServiceOrMin";
            this.txtServiceOrMin.Size = new System.Drawing.Size(145, 20);
            this.txtServiceOrMin.TabIndex = 14;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(182, 154);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(145, 20);
            this.txtInterestRate.TabIndex = 15;
            this.txtInterestRate.Visible = false;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(252, 354);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create Account";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(383, 25);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(238, 278);
            this.lblDisplay.TabIndex = 17;
            this.lblDisplay.Text = resources.GetString("lblDisplay.Text");
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(543, 354);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(92, 23);
            this.btnDeposit.TabIndex = 18;
            this.btnDeposit.Text = "Deposit $500";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Visible = false;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(543, 381);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(92, 23);
            this.btnWithdraw.TabIndex = 19;
            this.btnWithdraw.Text = "Withdraw $500";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Visible = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(437, 354);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(462, 381);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(252, 381);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BankingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(664, 416);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtServiceOrMin);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.chkCancelled);
            this.Controls.Add(this.chkFreeChecks);
            this.Controls.Add(this.chkFreeChecking);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblServiceOrMin);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "BankingApp";
            this.Text = "Banking Application";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSavings;
        private System.Windows.Forms.RadioButton rdbChecking;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblServiceOrMin;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.CheckBox chkFreeChecking;
        private System.Windows.Forms.CheckBox chkFreeChecks;
        private System.Windows.Forms.CheckBox chkCancelled;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtServiceOrMin;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
    }
}

