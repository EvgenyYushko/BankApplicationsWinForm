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
    public partial class CloseForm : Form
    {
        MainForm mainForm;
        Bank<Account> bank;
        public CloseForm()
        {
            InitializeComponent();
        }

        public CloseForm(MainForm mainForm, Bank<Account> bank)
        {
            InitializeComponent();
            mainForm.Enabled = false;
            this.mainForm = mainForm;
            this.bank = bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseAccount(bank);
            //mainForm.labelDay.Text += bank.CalculatePercentage();
            mainForm.labelInfo.ForeColor = Color.YellowGreen;
            mainForm.labelInfo.Text = "Счёт закрыт";
            this.Close();
            Service.Refresh(mainForm);
        }

        private void CloseAccount(Bank<Account> bank)
        {
            try
            {
                int id = Convert.ToInt32(this.textBox1.Text);
                bank.Close(id);

                Account[] acc = bank.GetAccunts();

                mainForm.ComboBox.DataSource = acc;
                mainForm.ComboBox.DisplayMember = "Name";
                mainForm.ComboBox.ValueMember = "Id";
            }
            catch (Exception)
            {
                MessageBox.Show("Нет такого счёта!", "Ошибка");
            }
        }

        private void CloseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
