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
    public partial class Form2 : Form
    {
        string Fname;
        string Lname;
        string Email;
        bool SMS;
        bool Reports;
        bool Transactions;
        
       
        public Form2(string f, string l, string e, bool s, bool r, bool t)
        {
            InitializeComponent();
            Fname = f;
            Lname = l;
            Email = e;
            SMS = s;
            Reports = r;
            Transactions = t;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblfName.Text = Fname;
            lbllName.Text = Lname;
            lblEmail.Text = Email;
            if(SMS)
            {
                lblSMS.Text = "✓";
            }
            if(Reports)
            {
                lblReports.Text = "✓";
            }
            if(Transactions)
            {
                lblTransactions.Text = "✓";
            }
        }


    }
}
