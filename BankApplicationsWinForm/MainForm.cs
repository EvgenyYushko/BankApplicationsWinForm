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
    public partial class MainForm : Form
    {
        ValidateForm validateForm;
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;
        public MainForm()
        {

        }
        public MainForm(ValidateForm validateForm)
        {
            InitializeComponent();
            this.validateForm = validateForm;
            infoLabel = new ToolStripLabel();
            infoLabel.Text = "Текущие дата и время:";
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();

            groupBox1.Text = "Клиент: " + validateForm._name;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        Bank<Account> bank = new Bank<Account>("ЮнитБанк");

        public ComboBox ComboBox
        {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }

        private void bOpen_Click(object sender, EventArgs e)
        {
            OpenForm openForm = new OpenForm(this, bank);
            openForm.Show();
        }

        private void bWithdraw_Click(object sender, EventArgs e)
        {
            WithdrawForm whothdrawFrom = new WithdrawForm(this, bank);
            whothdrawFrom.Show();
        }

        private void bPut_Click(object sender, EventArgs e)
        {
            PutForm putForm = new PutForm(this, bank);
            putForm.Show();
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            CloseForm closeForm = new CloseForm(this, bank);
            closeForm.Show();
            //bank.CalculatePercentage();
        }

        private void bSkip_Click(object sender, EventArgs e)
        {
            labelDay.Text = bank.CalculatePercentage();
        }
        

        private void bRefresh_Click(object sender, EventArgs e)
        {
            Service.Refresh(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Account acc = (Account)comboBox1.SelectedItem;
            if (acc != null)
            {
                //textBox3.Text = bank.GetPercent(acc.Id);
                textBox2.Text = acc.Sum.ToString();
                textBox3.Text = bank.GetPercent(acc.Id);
                textBox4.Text = acc._days.ToString();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            validateForm.Close();
        }
    }
}
