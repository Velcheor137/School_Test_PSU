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
   
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            admin newForm = new admin();
            newForm.Owner = this;
            newForm.ShowDialog();
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/art_delete_zero");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/velcheor13");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/id346763336");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (DataBank.Adm == false)
            {
                predTEST newForm = new predTEST();
                newForm.ShowDialog();
            }
            else
            {
                Тестирование f = new Тестирование();
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (DataBank.Adm == true)
            {
                admJURNAL n = new admJURNAL();
                n.ShowDialog();
            }
            else
            {
                Jurnal newForm = new Jurnal();
                newForm.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ((Control)sender).Hide();
            MessageBox.Show("Спасибо, что поддержал♥♥♥)))))", "PBV | Purple");
        }

        
        private void button6_Click(object sender, EventArgs e)
        {
            if (DataBank.Adm == true)
            {
                Zapolnenie zapoln = new Zapolnenie();
                zapoln.Show();
            }
            else MessageBox.Show("У вас нет доступа к данной функции, из-за отсутствия прав администатора", "Ошибка авторизации");
        }

       
    }   
}
