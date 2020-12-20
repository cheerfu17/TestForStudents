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

    public partial class Test2 : Form
    {
        ListBox lb1;
        ListBox lb2;

        MainWin f = new MainWin();


        string filePath = "";

        int flag = 1;


        int rightAnswer = 0; // сюда записываются правильные ответы
        int[] arrRightAnswer = new int[4]; // сюда записываются правильные ответы в виде массива (для выбора несклльних ответов) 



        int score = 0;
        int rbCheck = 0;
        int[] chBCheck = new int[4];

        public Test2(ListBox _lb1, ListBox _lb2, string _filePath)
        {
            lb1 = _lb1;
            lb2 = _lb2;
            filePath = _filePath;

            InitializeComponent();

            Theme2 t = new Theme2(label1, radioButton1, radioButton2, radioButton3, radioButton4, checkBox1, checkBox2, checkBox3, checkBox4, flag, button1);
            rightAnswer = t.rightAnswer;
            arrRightAnswer = t.arrRightAnswer;

            getArrChBCheck();
            f.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getArrChBCheck();
            //сравнивание правильного ответа и выбранной радиокнопкой
            if ((rightAnswer == rbCheck) | (isArraysAreEqual(arrRightAnswer, chBCheck) == true))
            {
                clearRightAnswerArray();
                score++;
            }

            if (button1.Text == "Закончить тест")
            {
                //показывает сколько правильных ответов дал пользователь
                MessageBox.Show($"Вы ответили правильно на {score} вопросов");


                //запись результатов в txt
                File.AppendAllText(f.filePath, $"В тесте 1 вы набрали {score} баллов\n");

                Update();
                //закрытие формы
                Close();
            }


            flag += 1;

            // В конструктор передаются необходимые ссылки на объекты с флагом, дальше конструктор обрабатывает флаг и направляет на нужный вопрос
            Theme2 t = new Theme2(label1, radioButton1, radioButton2, radioButton3, radioButton4, checkBox1, checkBox2, checkBox3, checkBox4, flag, button1);
            rightAnswer = t.rightAnswer;
            arrRightAnswer = t.arrRightAnswer;

        }


        //блок для определения выбранной радио-кнопки
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            rbCheck = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rbCheck = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rbCheck = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rbCheck = 4;
        }

        //загрузка данных в лист боксы
        public void Update()
        {

            //импорт строк из файла в массив
            string[] readText = File.ReadAllLines(filePath);
            //запись тем в listbox
            lb1.Items.Clear();
            lb1.Items.AddRange(f.themes);
            //запись результатов в listbox
            lb2.Items.Clear();
            lb2.Items.AddRange(readText);
        }

        //записывает в массив активные чек боксы
        public void getArrChBCheck()
        {
            if (checkBox1.Checked == true)
                chBCheck[0] = 1;
            else
                chBCheck[0] = 0;

            if (checkBox2.Checked == true)
                chBCheck[1] = 1;
            else
                chBCheck[1] = 0;

            if (checkBox3.Checked == true)
                chBCheck[2] = 1;
            else
                chBCheck[2] = 0;

            if (checkBox4.Checked == true)
                chBCheck[3] = 1;
            else
                chBCheck[3] = 0;
        }

        //функция которая сравнивает массивы
        public bool isArraysAreEqual(int[] a1, int[] a2)
        {
            int s = 0;

            for (int i = 0; i < 4; i++)
            {
                if (a1[i] == a2[i])
                {
                    s++;

                }
            }
            if (s == 4)
                return true;
            else
                return false;
        }
        //отчищает поля чек боксов, удаляет данные из массива
        public void clearRightAnswerArray()
        {

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;

            for (int i = 0; i < 4; i++)
                chBCheck[i] = 0;
        }

    }
}
