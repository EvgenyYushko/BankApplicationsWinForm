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
    public partial class ValidateForm : Form
    {
        MainForm mainFrom;

        
        public ValidateForm()
        {
            InitializeComponent();
            this.mainFrom = new MainForm(this);
            textBox1.Text = "Евгений";
            //отключили валидацию
            //mainFrom.Show();
            //this.Hide();
        }

        public string _name = "Евгений";
        string _pas = "123";

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(_name) && textBox2.Text.Equals(_pas))
            {
                mainFrom.Show();
                this.Hide();
            }
            else MessageBox.Show("Неверный логин или пароль", "Ошибка входа");
        }
    }
}
