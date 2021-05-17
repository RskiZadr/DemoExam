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
    public partial class Admin : Form
    {
        DataBase db = new DataBase();
        public Autorization auto { get; set; }
        public Сотрудники users { get; set; }
        public Admin()
        {
            InitializeComponent();
            сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var find = from b in db.Сотрудники
                       where b.ФИО.Contains(textBox1.Text)
                       select b;
            сотрудникиBindingSource.DataSource = find.ToList();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
            label2.Text = $"{users.Роль} {users.ФИО}";
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Autorization auto = new Autorization();
            auto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.db = db;
            DialogResult dr = users.ShowDialog();
            if (dr == DialogResult.OK)
            {
                сотрудникиBindingSource.DataSource = db.Сотрудники.ToList();
                MessageBox.Show("Зарегистрирован новый пользователь!");
            }
        }
    }
}
