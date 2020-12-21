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

        string filePath = @"D:\bin\student\CheerfulFolder\TestForStudents-main\Test\Test\score.txt";

        //названия тем
        public string[] themes = { "test1", "test2", "test3", "test4", "test5", "test6" };
        
        public Form1()
        {
            InitializeComponent();
            DataUpdate();
        }

        //запуск выбранного пользователем теста, пока только один
        private void button1_Click(object sender, EventArgs e)
        {
            Test1 t1 = new Test1();
            //берет значение индекса активной строки в listbox, потом используется для выбора темы
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

        private void Button3_Click(object sender, EventArgs e)
        {
            DataUpdate();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            listBox2.Items.Clear();
        }

        public void DataUpdate()
        {
            //подключение txt файла
            
            //импорт строк из файла в массив
            string[] readText = File.ReadAllLines(filePath);
            //запись тем в listbox
            listBox1.Items.Clear();
            listBox1.Items.AddRange(themes);
            //запись результатов в listbox
            listBox2.Items.Clear();
            listBox2.Items.AddRange(readText);
        }
    }
}
