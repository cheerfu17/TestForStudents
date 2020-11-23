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

namespace Test
{
    public partial class Form1 : Form
    {
        //думал понадобиться, но похоже это нужно будет дропнуть
        int flag = 0;

        

        //названия тем
        public string[] quastions = { "test1", "test2", "test3", "test4", "test5", "test6" };
        
        public Form1()
        {
            string filePath = @"C:\Users\demon\source\repos\Test\Test\Score.txt";
            string[] readText = File.ReadAllLines(filePath);
            
            InitializeComponent();
            listBox1.Items.AddRange(quastions);
            listBox2.Items.AddRange(readText);
        }

        //запуск выбранного пользователем теста, пока только один
        private void button1_Click(object sender, EventArgs e)
        {
            Test1 t1 = new Test1();
            int nTest = listBox1.SelectedIndex + 1;


            switch(nTest)
            {
                case 1:
                    {
                        t1.Show();
                        break;
                    }
            }
        }

        //потом удалю, или удалите кто-нибудь...
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
