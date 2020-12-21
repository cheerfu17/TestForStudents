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

    public partial class Test5 : Form
    {
        ListBox lb1;
        ListBox lb2;

        MainWin f = new MainWin();

        //путь будет слетать, нужно будет что-то делать с этим

        string filePath = "";

        int flag = 1;


        int eq = 0; // сюда записываются правильные ответы
        int score = 0;
        int rCheck = 0;

        public Test5(ListBox _lb1, ListBox _lb2, string _filePath)
        {
            lb1 = _lb1;
            lb2 = _lb2;
            filePath = _filePath;

            InitializeComponent();
            //filePath = f.GetPath() + @"score.txt";
            //как сделать иначе хз, но это по любому костыль
            Theme5 t = new Theme5(label1, radioButton1, radioButton2, radioButton3, radioButton4, flag, button1);
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
                File.AppendAllText(f.filePath, $"В тесте 5 вы набрали {score} баллов\n");

                f.DataUpdate();
                //закрытие формы

                Update();
                Close();
            }


            flag += 1;

            // В конструктор передаются необходимые ссылки на объекты с флагом, дальше конструктор обрабатывает флаг и направляет на нужный вопрос
            Theme5 t = new Theme5(label1, radioButton1, radioButton2, radioButton3, radioButton4, flag, button1);
            eq = t.rightAnswer;
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
    }
}
