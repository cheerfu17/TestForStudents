﻿using System;
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

    public partial class Test1 : Form
    {


        Form1 f = new Form1();

        //путь будет слетать, нужно будет что-то делать с этим
        string filePath = @"D:\bin\student\CheerfulFolder\TestForStudents-main\Test\Test\score.txt";

        int flag = 1;

        
        int eq = 0; // сюда записываются правильные ответы
        int score = 0;
        int rCheck = 0;

        public Test1()
        {

            InitializeComponent();
            //как сделать иначе хз, но это по любому костыль
            Thame1 t = new Thame1(label1, radioButton1, radioButton2, radioButton3, radioButton4, flag, button1);
            eq = t.rightAnswer;

            f.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //сравнивание правильного ответа и выбранной радиокнопкой
            if (eq == rCheck)
            {
                score++;
            }
            //ничего лучше и проще для проверки на конец теста придумать не мог, пока так
            if (button1.Text == "Закончить тест")
            {   
                //показывает сколько правильных ответов дал пользователь
                MessageBox.Show($"Вы ответили правильно на {score} вопросов");


                //запись результатов в txt
                File.AppendAllText(filePath, $"В тесте 1 вы набрали {score} баллов\n");

                f.DataUpdate();
                //закрытие формы
                this.Close();
            }


            flag += 1;

            // В конструктор передаются необходимые ссылки на объекты с флагом, дальше конструктор обрабатывает флаг и направляет на нужный вопрос
            Thame1 t = new Thame1(label1, radioButton1, radioButton2, radioButton3, radioButton4, flag, button1);
            eq = t.rightAnswer;
            //отладка
            MessageBox.Show(eq + " " + rCheck + " " + score);

        }


        //блок для определения выбранной радио-кнопки
        private void radioButton1_CheckedChanged(object sender, EventArgs e)  
        {
            rCheck = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            rCheck = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            rCheck = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            rCheck = 4;
        }
    }
}
