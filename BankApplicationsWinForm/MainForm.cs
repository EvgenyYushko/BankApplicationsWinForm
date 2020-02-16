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
using System.Xml.Serialization;
using System.IO;
using System.Diagnostics;

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
            labelDayProp.Text = bank.CalculatePercentage();
            UpdateInfo();
            Service.LogWrite(labelDayProp.Text);
        }

        private void bRefresh_Click(object sender, EventArgs e)
        {
            Service.Refresh(this);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateInfo();
        }

        public void UpdateInfo()
        {
            Account acc = (Account)comboBox1.SelectedItem;
            if (acc != null)
            {
                //textBox3.Text = bank.GetPercent(acc.Id);
                TextBox2Prop.Text = acc.Sum.ToString();
                TextBox3Prop.Text = bank.GetPercent(acc.Id);
                TextBox4Prop.Text = acc._days.ToString();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            validateForm.Close();
        }

        #region Свойства для доступа к полям MainForm

        public Panel Panel
        {
            get { return panel1; }
            set { panel1 = value; }
        }

        public ComboBox ComboBox
        {
            get { return comboBox1; }
            set { comboBox1 = value; }
        }

        public Label labelDayProp
        {
            get => labelDay;
            set => labelDay = value;
        }

        public Label LabelInfoProp
        {
            get => labelInfo;
            set => labelInfo = value;
        }

        public TextBox TextBox2Prop
        {
            get { return textBox2; }
            set { textBox2 = value; }
        }

        public TextBox TextBox3Prop
        {
            get { return textBox3; }
            set { textBox3 = value; }
        }

        public TextBox TextBox4Prop
        {
            get { return textBox4; }
            set { textBox4 = value; }
        }
        #endregion

        #region Сериализация/Десериализация объеткта Account

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer formatterDemand = new XmlSerializer(typeof(DemandAccount[]));
            XmlSerializer formatterDeposit = new XmlSerializer(typeof(DepositAccount[]));
            List<DemandAccount> demList = new List<DemandAccount>();
            List<DepositAccount> depList = new List<DepositAccount>();

            try
            {
                using (var stream = new FileStream("DemandAccounts.xml", FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    DemandAccount s;

                    foreach (Account item in bank.accounts)
                    {
                        if (item is DemandAccount)
                        {
                            s = item as DemandAccount;
                            demList.Add(s);
                        }
                    }
                    formatterDemand.Serialize(stream, demList.ToArray());
                    Service.LogWrite("Объект DemandAccount сохранён");
                }
                using (var stream = new FileStream("DepositAccounts.xml", FileMode.Create, FileAccess.Write, FileShare.Read))
                {
                    DepositAccount s;
                    foreach (Account item in bank.accounts)
                    {
                        if (item is DepositAccount)
                        {
                            s = item as DepositAccount;
                            depList.Add(s);
                        }
                    }
                    formatterDeposit.Serialize(stream, depList.ToArray());
                    Service.LogWrite("Объект DemandAccount сохранён");
                }
                this.button1.Text = "ОК";
                Service.LogWrite("Сохранение ОК");
            }
            catch (Exception)
            {
                this.button1.Text = "Error";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            XmlSerializer serializerDem = new XmlSerializer(typeof(DemandAccount[]));
            XmlSerializer serializerDep = new XmlSerializer(typeof(DepositAccount[]));

            DemandAccount[] demAcc;
            DepositAccount[] depAcc;

            try
            {
                using (var stream = new FileStream("DemandAccounts.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    // Восстанавливаем объект из XML-файла.
                    demAcc = serializerDem.Deserialize(stream) as DemandAccount[];
                    Service.LogWrite("Объект DemandAccount загружен");
                }

                using (var stream = new FileStream("DepositAccounts.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    // Восстанавливаем объект из XML-файла.
                    depAcc = serializerDep.Deserialize(stream) as DepositAccount[];
                    Service.LogWrite("Объект DepositAccount загружен");
                }

                Account[] tempAccounts = new Account[demAcc.Length + depAcc.Length];
                for (int i = 0; i < demAcc.Length; i++)
                    tempAccounts[i] = demAcc[i];
                for (int i = 0, s = demAcc.Length, t = demAcc.Length; t < depAcc.Length + demAcc.Length; i++, s++, t++)
                    tempAccounts[s] = depAcc[i];
                bank.accounts = tempAccounts;

                Account[] acc = bank.GetAccunts();

                ComboBox.DataSource = acc;
                ComboBox.DisplayMember = "Name";
                ComboBox.ValueMember = "Id";
                this.button2.Text = "ОК";
                Service.LogWrite("Загрзка ОК");
            }
            catch (Exception)
            {
                this.button2.Text = "Error";
            }

        }
        #endregion

        private void журналСобытийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@"E:\С#\Мои проекты\BankApplicationsWinForm\BankApplicationsWinForm\bin\Debug\trace.txt");
        }
    }

}
