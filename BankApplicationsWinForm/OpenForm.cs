using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankLibrary;
using BankLibrary.Enams;

namespace BankApplicationsWinForm
{
    public partial class OpenForm : Form
    {
        MainForm mainForm;
        Bank<Account> bank;

        public OpenForm()
        {
            InitializeComponent();
        }

        public OpenForm(MainForm mainForm, Bank<Account> bank)
        {
            InitializeComponent();
            mainForm.Enabled = false;
            this.mainForm = mainForm;
            this.bank = bank;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            OpenAccount(bank);
            //mainForm.labelDay.Text = bank.CalculatePercentage();


            Account[] acc = bank.GetAccunts();

            mainForm.ComboBox.DataSource = acc;
            mainForm.ComboBox.DisplayMember = "Name";
            mainForm.ComboBox.ValueMember = "Id";

            this.Close();
        }

        public void OpenAccount(Bank<Account> bank)
        {
            decimal sum = Convert.ToDecimal(this.textBox1.Text);
            AccountType accountType;

            int type = Convert.ToInt32(this.textBox2.Text);

            if (type == 2)
                accountType = AccountType.Deposit;
            else
                accountType = AccountType.Ordinary;

            bank.Open(accountType,
                sum,
                AddSumHandler,  // обработчик добавления средств на счет
                WithdrawSumHandler, // обработчик вывода средств
                (o, e) => mainForm.labelPer.Text = e.Message, // обработчик начислений процентов в виде лямбда-выражения
                CloseAccountHandler, // обработчик закрытия счета
                OpenAccountHandler); // обработчик открытия счета
        }
        
        // обработчики событий класса Account
        // обработчик открытия счета
        private void OpenAccountHandler(object sender, AccountEventArgs e)
        {
            DialogResult result = MessageBox.Show(e.Message, "Результат");

            this.mainForm.labelInfo.Text = e.Message;
            this.Close();
        }
        // обработчик добавления денег на счет
        private void AddSumHandler(object sender, AccountEventArgs e)
        {
            mainForm.labelInfo.ForeColor = Color.Green;
            mainForm.labelInfo.Text = e.Message;
            mainForm.labelInfo.Text += "\n"+"Общая сумма равна:" + e.Sum;

        }
        // обработчик вывода средств
        private void WithdrawSumHandler(object sender, AccountEventArgs e)
        {
            mainForm.labelInfo.Text = e.Message;
            if (e.Sum > 0)
                mainForm.labelInfo.Text += "Идем тратить деньги";
        }
        // обработчик закрытия счета
        private void CloseAccountHandler(object sender, AccountEventArgs e)
        {
            this.label1.Text = e.Message;
        }
        
        private void OpenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
