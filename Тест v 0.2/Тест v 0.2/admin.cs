using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_v_0._2
{
    
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            
        }
        
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            string ps = textBox1.Text;
            if (ps == DataBank.Pass)
            {
                DataBank.Adm = true;
                if (main != null)
                {
                    main.label2.Text = "Administrator";
                }
                MessageBox.Show("Вы получили права администратора!", "Успешная авторизация");
                Close();
            }
            else {
                MessageBox.Show("Неправильно введён пароль!", "Ошибка авторизации");
                Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DataBank.Adm == false)
            {
                MessageBox.Show("У вас нет доступа к правам администратора, куда вы собрались выходить?", "Успех");
                Close();
            }
            else
            {
                Form1 main = this.Owner as Form1;
                main.label2.Text = "User";
                DataBank.Adm = false;
                MessageBox.Show("Вы вышли из аккаунта администратора, все особые права отключены!", "Успех");
                Close();
            }
        }
    }
}
