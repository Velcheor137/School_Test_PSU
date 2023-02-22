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
    public partial class admJURNAL : Form
    {
        public admJURNAL()
        {
            InitializeComponent();
            string completedPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "База данных");
            Directory.CreateDirectory(completedPath);
            string p = Path.Combine(completedPath, "DataBase.txt");      
            StreamReader f = new StreamReader(p);
            string[] ss = new string[100];
            ss = File.ReadAllLines(p);
            int n = ss.Count();
            String s0 = Environment.NewLine;
            string u1 = "";
            string u2 = "";
            for (int i = 0; i < n; i++)
            {
                u1 = ss[i].Substring(ss[i].IndexOf('&')+1);
                u1 = u1.Substring(0, u1.IndexOf('/'));
                u1 = (i+1) + ". " + u1;
                u2 = ss[i].Substring(ss[i].Length - 2);
                u2 = u2.Replace("/", "");
                label3.Text += (u1 + s0);
                label1.Text += ("            "+u2 + s0);
            }
            f.Close();

        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
