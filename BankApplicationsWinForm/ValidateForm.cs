using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace BankApplicationsWinForm
{
    public partial class ValidateForm : Form
    {
        MainForm mainFrom;
        CreateUserForm createUserForm;
        public User user;
        List<User> listUser;

        public ValidateForm()
        {
            InitializeComponent();
            textBox1.Text = "Евгений";
            //отключили валидацию
            //mainFrom.Show();
            //this.Hide();
            listUser = new List<User>();
        }

        public string _name = "Евгений";
        string _pas = "1";

        public TextBox ValidTextBox
        {
            get { return textBox1; }
            set { textBox1 = value; }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlSerializer deserializeUser = new XmlSerializer(typeof(List<User>));
            try
            {
                using (var stream = new FileStream($"UsersData.xml", FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    listUser = deserializeUser.Deserialize(stream) as List<User>;
                    Service.LogWrite($"User {textBox1.Text} загружен");
                }
            }
            catch (Exception ex)
            {
                Service.LogWrite($"{ex.Message}");
                MessageBox.Show($"Пользователя {textBox1.Text} нет в системе", "Ошибка входа");
                return;
            }

            foreach (User item in listUser)
            {
                if (item.Name == textBox1.Text)
                {
                    user = item;
                    Service.LogWrite($"{user.Name} найден в системе");
                    if (textBox2.Text.Equals(user.Password))
                    {
                        this.mainFrom = new MainForm(this);
                        mainFrom.Show();
                        this.Hide();
                    }
                    else MessageBox.Show("Неверный логин", "Ошибка входа");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.createUserForm = new CreateUserForm();
            createUserForm.Show();
        }
    }
}
