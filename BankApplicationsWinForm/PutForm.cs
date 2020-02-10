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
    public partial class PutForm : Form
    {
        MainForm mainForm;
        Bank<Account> bank;
        public PutForm()
        {
            InitializeComponent();
        }

        public PutForm(MainForm mainForm, Bank<Account> bank)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.mainForm.Enabled = false;
            this.bank = bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Put(bank);
            //openForm.labelDay.Text = bank.CalculatePercentage();
            this.Close();
        }

        private void Put(Bank<Account> bank)
        {
            decimal sum = Convert.ToDecimal(this.textBox1.Text);

            int id = Convert.ToInt32(this.textBox2.Text);
            bank.Put(sum, id);
        }

        private void PutForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.mainForm.Enabled = true;
        }
    }
}
