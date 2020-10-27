namespace PassingInfoForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkSMS = new System.Windows.Forms.CheckBox();
            this.chkReports = new System.Windows.Forms.CheckBox();
            this.chkTransactions = new System.Windows.Forms.CheckBox();
            this.lblSMSMessage = new System.Windows.Forms.Label();
            this.lblReportsMessage = new System.Windows.Forms.Label();
            this.lblTransactionsMessage = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(156, 44);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(190, 20);
            this.txtFname.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(156, 100);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(156, 73);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(190, 20);
            this.txtLname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(71, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 143);
            this.label4.TabIndex = 6;
            this.label4.Text = "Services";
            // 
            // chkSMS
            // 
            this.chkSMS.AutoSize = true;
            this.chkSMS.Location = new System.Drawing.Point(153, 187);
            this.chkSMS.Name = "chkSMS";
            this.chkSMS.Size = new System.Drawing.Size(49, 17);
            this.chkSMS.TabIndex = 7;
            this.chkSMS.Text = "SMS";
            this.chkSMS.UseVisualStyleBackColor = true;
            this.chkSMS.CheckedChanged += new System.EventHandler(this.chkSMS_CheckedChanged);
            // 
            // chkReports
            // 
            this.chkReports.AutoSize = true;
            this.chkReports.Location = new System.Drawing.Point(153, 210);
            this.chkReports.Name = "chkReports";
            this.chkReports.Size = new System.Drawing.Size(63, 17);
            this.chkReports.TabIndex = 8;
            this.chkReports.Text = "Reports";
            this.chkReports.UseVisualStyleBackColor = true;
            this.chkReports.CheckedChanged += new System.EventHandler(this.chkReports_CheckedChanged);
            // 
            // chkTransactions
            // 
            this.chkTransactions.AutoSize = true;
            this.chkTransactions.Location = new System.Drawing.Point(153, 233);
            this.chkTransactions.Name = "chkTransactions";
            this.chkTransactions.Size = new System.Drawing.Size(87, 17);
            this.chkTransactions.TabIndex = 9;
            this.chkTransactions.Text = "Transactions";
            this.chkTransactions.UseVisualStyleBackColor = true;
            this.chkTransactions.CheckedChanged += new System.EventHandler(this.chkTransactions_CheckedChanged);
            // 
            // lblSMSMessage
            // 
            this.lblSMSMessage.AutoSize = true;
            this.lblSMSMessage.Location = new System.Drawing.Point(311, 188);
            this.lblSMSMessage.Name = "lblSMSMessage";
            this.lblSMSMessage.Size = new System.Drawing.Size(35, 13);
            this.lblSMSMessage.TabIndex = 10;
            this.lblSMSMessage.Text = "label5";
            // 
            // lblReportsMessage
            // 
            this.lblReportsMessage.AutoSize = true;
            this.lblReportsMessage.Location = new System.Drawing.Point(311, 211);
            this.lblReportsMessage.Name = "lblReportsMessage";
            this.lblReportsMessage.Size = new System.Drawing.Size(35, 13);
            this.lblReportsMessage.TabIndex = 11;
            this.lblReportsMessage.Text = "label6";
            // 
            // lblTransactionsMessage
            // 
            this.lblTransactionsMessage.AutoSize = true;
            this.lblTransactionsMessage.Location = new System.Drawing.Point(311, 234);
            this.lblTransactionsMessage.Name = "lblTransactionsMessage";
            this.lblTransactionsMessage.Size = new System.Drawing.Size(35, 13);
            this.lblTransactionsMessage.TabIndex = 12;
            this.lblTransactionsMessage.Text = "label7";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(425, 268);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(96, 41);
            this.btnSignUp.TabIndex = 13;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.lblTransactionsMessage);
            this.Controls.Add(this.lblReportsMessage);
            this.Controls.Add(this.lblSMSMessage);
            this.Controls.Add(this.chkTransactions);
            this.Controls.Add(this.chkReports);
            this.Controls.Add(this.chkSMS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkSMS;
        private System.Windows.Forms.CheckBox chkReports;
        private System.Windows.Forms.CheckBox chkTransactions;
        private System.Windows.Forms.Label lblSMSMessage;
        private System.Windows.Forms.Label lblReportsMessage;
        private System.Windows.Forms.Label lblTransactionsMessage;
        private System.Windows.Forms.Button btnSignUp;
    }
}

