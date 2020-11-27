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

        string filePathCollege = @"D:\bin\student\CheerfulFolder\TestForStudents-main\Test\Test\score.txt";
        string filePathHome = @"D:\Project\C#\TestForStudents-main\Test\Test\score.txt";
        string filePath = "";

        //названия тем
        public string[] themes = { "Переменные и типы данных", "Циклы", "Массивы", "Операторы", "ООП" };
        
        public Form1()
        {
            InitializeComponent();
            filePath = filePathHome;
            DataUpdate();
        }

        //запуск выбранного пользователем теста, пока только один
        private void button1_Click(object sender, EventArgs e)
        {
            Test1 t1 = new Test1();
            Test2 t2 = new Test2();
            Test3 t3 = new Test3();
            //берет значение индекса активной строки в listbox, потом используется для выбора темы
            int nTest = listBox1.SelectedIndex + 1;


            switch(nTest)
            {
            case 1:
                t1.Show();
                break;
            case 2:
                t2.Show();
                break;
            case 3:
                t3.Show();
                break;
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

        public string GetPath()
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "");
            return path;
        }
    }
}
