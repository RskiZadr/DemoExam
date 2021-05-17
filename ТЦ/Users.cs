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
    public partial class Users : Form
    {
        public Сотрудники user { get; set; }

        public DataBase db { get; set; }
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            номер_телефонаMaskedTextBox.Mask = "+7(000)000-0000";
            сотрудникиBindingSource.AddNew();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = (Сотрудники)сотрудникиBindingSource.List[0];
            db.Сотрудники.Add(user);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
