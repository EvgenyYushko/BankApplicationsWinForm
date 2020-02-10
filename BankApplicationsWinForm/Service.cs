using BankLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplicationsWinForm
{
    static public class Service
    {

        

        //public void Withdraw(Bank<Account> bank)
        //{
        //    OpenForm form3 = new OpenForm();
        //    form3.Show();
        //}
        static public void Refresh(MainForm mainForm)
        {
           MainForm mainForm1= mainForm;
            mainForm1.labelPer.Text = "";
            mainForm1.labelDay.Text = "";

        }
        //public void Put(Bank<Account> bank)
        //{
        //    Console.WriteLine("Укажите сумму, чтобы положить на счет:");
        //    decimal sum = Convert.ToDecimal(this.textBox1.Text);
        //    Console.WriteLine("Введите Id счета:");
        //    int id = Convert.ToInt32(this.textBox2.Text);
        //    bank.Put(sum, id);
        //}

        //public void CloseAccount(Bank<Account> bank)
        //{
        //    this.label1.Text = "Введите id счета, который надо закрыть:";
        //    int id = Convert.ToInt32(this.textBox2.Text);

        //    bank.Close(id);
        //}
        // //обработчики событий класса Account
        // //обработчик открытия счета
        //public void OpenAccountHandler(object sender, AccountEventArgs e)
        //{
        //    this.label1.Text = e.Message;
        //}
        // //обработчик добавления денег на счет
        //public void AddSumHandler(object sender, AccountEventArgs e)
        //{
        //    this.label1.Text = e.Message;
        //}
        //// обработчик вывода средств
        //public void WithdrawSumHandler(object sender, AccountEventArgs e)
        //{
        //    this.label1.Text = e.Message;
        //    if (e.Sum > 0)
        //        this.label1.Text = "Идем тратить деньги";
        //}
        //// обработчик закрытия счета
        //public void CloseAccountHandler(object sender, AccountEventArgs e)
        //{
        //    this.label1.Text = e.Message;
        //}
    }
}
