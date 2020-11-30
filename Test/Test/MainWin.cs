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
using System.Threading;

namespace Test
{
    public partial class MainWin : Form
    {
        public string filePath = "";
        string curFile = Directory.GetCurrentDirectory() + @"\score.txt";

        //названия тем
        public string[] themes = { "1. Переменные и типы данных", "2. Циклы", "3. Массивы", "4. Операторы и выражения", "5. ООП" };
        
        public MainWin()
        {
            //создание нового файла если его не существует в папке с exe файлом
            if (File.Exists(curFile) == false)
            {
                File.AppendAllText("score.txt", "");
                Thread.Sleep(2000);


            }
            filePath = curFile;

            InitializeComponent();
            DataUpdate();
        }

        //запуск выбранного пользователем теста, пока только один
        private void button1_Click(object sender, EventArgs e)
        {
            Test1 t1 = new Test1(listBox1,listBox2, filePath);
            Test2 t2 = new Test2(listBox1, listBox2, filePath);
            Test3 t3 = new Test3(listBox1, listBox2, filePath);
            Test4 t4 = new Test4(listBox1, listBox2, filePath);
            Test5 t5 = new Test5(listBox1, listBox2, filePath);
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
            case 4:
                t4.Show();
                break;
            case 5:
                t5.Show();
                break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            listBox2.Items.Clear();
        }

        public void DataUpdate()
        {
            //импорт строк из файла в массив
            string[] readText = File.ReadAllLines(filePath);
            //запись тем в listbox
            listBox1.Items.Clear();
            listBox1.Items.AddRange(themes);
            //запись результатов в listbox
            listBox2.Items.Clear();
            listBox2.Items.AddRange(readText);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //секция "О приложении"
            About about = new About();
            about.Show();
        }

        private void CreatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Секция "Создатели"
            Creators creators = new Creators();
            creators.Show();
        }
    }
}
