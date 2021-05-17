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
    public partial class Captcha : Form
    {
        int random;
        int check;
        bool b = false;
        public Captcha()
        {
            InitializeComponent();
            Random rd = new Random();
            random = rd.Next(0,100);
            label1.Text = $"Введите число {random}";
        }

        private void Captcha_FromClosin(object sender, FormClosingEventArgs e)
        {
            if (b == false)
            {
                MessageBox.Show("Пройди капчу!");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                b = true;
                check = Convert.ToInt32(textBox1.Text);
                if (check == random)
                {
                    DialogResult = DialogResult.Yes;
                }
                else
                {
                    DialogResult = DialogResult.No;
                }
            }
            catch
            {
                MessageBox.Show("Что то ты ввел не верно!");
            }
        }
    }
}
