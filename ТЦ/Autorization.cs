using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ТЦ
{
    public partial class Autorization : Form
    {
        
        DataBase db = new DataBase();
        int count = 1;
        public Autorization()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать логин или пароль");
                return;
            }
            if (count == 3)
            {
                count = 0;
                Captcha captcha = new Captcha();
                DialogResult dr = captcha.ShowDialog();
                if (dr == DialogResult.No)
                {
                    MessageBox.Show("Ты робот");
                    this.Dispose();
                }
                else
                {
                    textBox2.Text = "";
                }
            }
            foreach (Сотрудники users in db.Сотрудники)
            {
                if (users != null && users.Пароль == textBox2.Text)
                {
                    if (users.Роль == "Администратор")
                    {
                        Admin admin = new Admin();
                        admin.auto = this;
                        admin.users = users;
                        this.Hide();
                        admin.Show();
                    }
                    else if (users.Роль == "Менеджер C")
                    {
                        ManageC manageC = new ManageC();
                        this.Hide();
                        manageC.Show();
                    }
                    else if (users.Роль == "Менеджер А")
                    {
                        ManageA manageA = new ManageA();
                        this.Hide();
                        manageA.Show();
                    }
                    return;
                }
                
            }
            count++;
            




        }
    }
}
