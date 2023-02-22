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
    public partial class predTEST : Form
    {
        public predTEST()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
            string h = textBox1.Text;
            string u3 = "";
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
                        DataBank.Nick = h;
                        
                    }
                }

                f.Close();
                if (DataBank.Prv == true)
                {
                    Тестирование newForm = new Тестирование();
                    newForm.ShowDialog();
                    Close();
                }
                else MessageBox.Show("Извините, но вы не зарегистрированы в базе!", "Ошибка");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            
        }

    }
}
