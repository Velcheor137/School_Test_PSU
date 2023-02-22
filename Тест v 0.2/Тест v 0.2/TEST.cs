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
    public partial class Тестирование : Form
    {
        public Тестирование()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = 0;
            if (radioButton40.Checked == true) b = b + 1;//1
            if (radioButton33.Checked == true) b = b + 1;//2
            if (radioButton27.Checked == true) b = b + 1;//3
            if (radioButton15.Checked == true) b = b + 1;//4
            if (radioButton10.Checked == true) b = b + 1;//5
            if (radioButton5.Checked == true) b = b + 1;//6
            if (radioButton2.Checked == true) b = b + 1;//7
            if (radioButton31.Checked == true) b = b + 1;//8
            if (radioButton22.Checked == true) b = b + 1;//9
            if (radioButton18.Checked == true) b = b + 1;//10
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true) b = b + 0;//11
            else if (checkBox1.Checked == true && checkBox4.Checked == true) b = b + 2;
            else if (checkBox1.Checked == true || checkBox4.Checked == true) b = b + 1;
            if (checkBox8.Checked == true && checkBox6.Checked == true && checkBox5.Checked == true && checkBox7.Checked == true) b = b + 0;//12
            else if (checkBox8.Checked == true && checkBox6.Checked == true && checkBox5.Checked == true) b = b + 2;
            else if (checkBox8.Checked == true || checkBox6.Checked == true || checkBox5.Checked == true) b = b + 1;
            if (checkBox10.Checked == true && checkBox9.Checked == true && checkBox11.Checked == true && checkBox12.Checked == true) b = b + 0;//13
            else if (checkBox10.Checked == true && checkBox9.Checked == true) b = b + 2;
            else if (checkBox10.Checked == true || checkBox9.Checked == true) b = b + 1;
            if (checkBox16.Checked == true && checkBox13.Checked == true && checkBox14.Checked == true && checkBox15.Checked == true) b = b + 0;//14
            else if (checkBox16.Checked == true && checkBox13.Checked == true) b = b + 2;
            else if (checkBox16.Checked == true || checkBox13.Checked == true) b = b + 1;
            if (checkBox19.Checked == true && checkBox18.Checked == true && checkBox17.Checked == true && checkBox20.Checked == true) b = b + 0;//15
            else if (checkBox19.Checked == true && checkBox18.Checked == true && checkBox17.Checked == true) b = b + 2;
            else if (checkBox19.Checked == true || checkBox18.Checked == true || checkBox17.Checked == true) b = b + 1;
            string v16 = textBox1.Text;
            if (v16 == "15") b = b + 3;//16
            string v17 = textBox2.Text;
            if (v17 == "8") b = b + 3;//17
            string v18 = textBox3.Text;
            if (v18 == "101011101" || v18 == "101 011 101") b = b + 3;//18
            string v19 = textBox4.Text;
            if (v19 == "интерфейс" || v19 == "Интерфейс") b = b + 3;//19
            string v20 = textBox5.Text;
            if (v20 == "7") b = b + 3;//20

            if (DataBank.Adm == true)
            {
                MessageBox.Show("Вы завершили тест! Ваши баллы: " + b, "");
                Close();
            }
            else
            {
                string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "База данных");
                Directory.CreateDirectory(completedPath);
                string p = Path.Combine(completedPath, "DataBase.txt");
                StreamReader f = new StreamReader(p);
                string[] ss = new string[100];
                ss = File.ReadAllLines(p);
                int n = ss.Count();
                for (int i = 0; i < n; i++)
                {
                    string j = ss[i];
                    if (j.ToLower().Contains(DataBank.Nick))
                    {
                        int k = ss[i].IndexOf("/");
                        if (k > 0) ss[i] = ss[i].Substring(0, k+1);
                        ss[i] = ss[i] + b;
                        
                    }
                }

                f.Close();
                DataBank.Nick = "";
                using (StreamWriter f1 = new StreamWriter(p, false))
                {
                    foreach (string str in ss)
                    {
                        f1.WriteLine(str);
                    }
                }
                MessageBox.Show("Вы завершили тест!", "Тест");
                Close();

            }

        }
    }
}
