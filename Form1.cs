using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassingInfoForms
{
    public partial class Form1 : Form
    {
        string Fname;
        string Lname;
        string Email;
        bool SMS;
        bool Reports;
        bool Transactions;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSMSMessage.Text = "";
            lblReportsMessage.Text = "";
            lblTransactionsMessage.Text = "";

            lblSMSMessage.ForeColor = System.Drawing.Color.Red;
            lblReportsMessage.ForeColor = System.Drawing.Color.HotPink;
            lblTransactionsMessage.ForeColor = System.Drawing.Color.MediumAquamarine;


        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSMS.Checked)
            { 
                lblSMSMessage.Text = "Service rates may apply";
            }
            else
            {
                lblSMSMessage.Text = "";
            }
        }

        private void chkReports_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReports.Checked)
            {
                lblReportsMessage.Text = "Service rates may apply";
            }
            else
            {
                lblReportsMessage.Text = "";
            }
        }

        private void chkTransactions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransactions.Checked)
            {
                lblTransactionsMessage.Text = "Service rates may apply";
            }
            else
            {
                lblTransactionsMessage.Text = "";
            }
        }

        private void Signup()
        {
            Fname = txtFname.Text;
            Lname = txtLname.Text;
            Email = txtEmail.Text;
            SMS = chkSMS.Checked;
            Reports = chkReports.Checked;
            Transactions = chkTransactions.Checked;

            Form2 n = new Form2(Fname, Lname, Email, SMS, Reports, Transactions);
            n.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Signup();
        }

    }
}
