using BankLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplicationsWinForm
{
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }
        MainForm mainForm;
        Bank<Account> bank;
        public WithdrawForm(MainForm mainForm, Bank<Account> bank)
        {
            InitializeComponent();
            mainForm.Enabled = false;
            this.mainForm = mainForm;
            this.bank = bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Withdraw(bank);
            //form1.labelDay.Text = bank.CalculatePercentage();
            this.Close();
        }

        private void Withdraw(Bank<Account> bank)
        {
            decimal sum = Convert.ToDecimal(this.textBox1.Text);
            int id = Convert.ToInt32(this.textBox2.Text);
            bank.Withdraw(sum, id);
        }

        private void WithdrawForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
