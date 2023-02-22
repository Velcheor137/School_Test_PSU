using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Тест_v_0._2
{
    public partial class Jurnal : Form
    {
        public Jurnal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "База данных");
            Directory.CreateDirectory(completedPath);
            string p = Path.Combine(completedPath, "DataBase.txt");
            StreamReader f = new StreamReader(p);
            string[] ss = new string[100];
            ss = File.ReadAllLines(p);
            int n = ss.Count();
            string u = " ";
            string u2 = "";
            string u3 = "";
            string h = textBox1.Text;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Вы не ввели имя пользователя!", "Ошибка");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    string j = ss[i];
                    u3 = j.Substring(0, 5);
                    if (u3.ToLower().Contains(h))
                    {
                        DataBank.Prv = true;
                        u = j;
                        u2 = u.Substring(u.Length - 2);
                        u2 = u2.Replace("/", "");
                        
                    }
                }
                
                f.Close();

                if (DataBank.Prv == true)
                {
                    DataBank.Prv = false;
                    MessageBox.Show("Ваши баллы: " + u2, "Успех!");
                    Close();

                }
                else
                {
                    MessageBox.Show("Извините, но вы не зарегистрированы в базе!", "Ошибка");
                    Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
